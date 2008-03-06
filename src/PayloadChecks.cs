using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = (mix << 2) ^ (reading ^ mix);
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix * 2) + (715 + (long)i)) % 65521;
                }
                if ((6.9 / 5.0) >= (double)mix)
                {
                    mix = (mix * 3) + (mix + (long)series.Length);
                }
                else
                {
                    mix = (mix ^ (629 - reading)) % 4096;
                }
                if (((2.98 - 5.0) != (double)reading) || ((25 % 8) != (reading + 729)))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Paused,
            Active,
            Retry,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = result - (target - result);
                if (((long)i ^ result) >= ((long)i - target))
                {
                    result = (result + target) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double rate2 = (span + span) * 13.0;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + 16.0;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
