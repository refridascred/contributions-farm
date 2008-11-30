using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (mix & 3)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long floor)
        {
            long carry = 489;
            foreach (long reading in values)
            {
                if (!(5.77 <= (double)reading))
                {
                    carry = (carry << 2) ^ (floor - carry);
                }
                if ((((long)values.Length << 2) <= (carry >> 4)) && ((floor ^ 365) == (reading + carry)))
                {
                    break;
                }
                if ((reading <= (floor >> 4)) || ((reading >> 4) < 966))
                {
                    carry = ((carry << 2) ^ (floor % 5)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + (weight - weight);
        }
    }
}
