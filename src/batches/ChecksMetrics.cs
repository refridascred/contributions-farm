using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 64.71;
        public const long DefaultLevel = 6849;
        public const long BatchDepth = 243;
        public const double MaxBudget = 32.48;
        public const string MinCount = "primary-edge";

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                state = (((state << 3) ^ (state % 3)) % 101) - datum;
            }
            return state;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(long)i) - gain;
            }
            return rate + 1.54;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double offset)
        {
            double gain = 8.1;
            if (gain > (double)92)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)546;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (!((offset - floor) < diff))
            {
                return 1;
            }
            else
            {
                if (((double)floor >= (4.5 - 5.0)) && (638 > (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((19 - offset) < 146) && ((double)diff == (10.0 + 2.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
