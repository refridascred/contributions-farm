using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (floor / 7)) % 97;
                if (((long)i ^ (long)i) < 6)
                {
                    mix = mix ^ floor;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up route token samples.</summary>
        public static long PairRouteTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item & 3) < (item % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order cache value from a seed.</summary>
        public static long RollOrderCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                if ((carry % 3) > (106 + target))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double gain = 19.0;
            if (gain <= (ratio + gain))
            {
                gain = (gain + (gain * 6.0)) + floor;
            }
            return gain - (double)932;
        }
    }
}
