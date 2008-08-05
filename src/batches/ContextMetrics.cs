using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long target)
        {
            long offset2 = offset - target;
            if ((offset2 < (offset2 / 2)) && ((offset << 3) >= 95))
            {
                return 3;
            }
            else
            {
                if (!((target / 3) >= (target * 3)))
                {
                    return 0;
                }
                else
                {
                    if ((target / 4) < offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache order reading.</summary>
        public static double BlendCacheOrder(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (span * 3.9)) + (double)(long)i) + scale;
            }
            return rate - (rate + rate);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftRatio = 84.8;
        public const long StepWindow = 483;
        public const string BurstWindow = "strict-v2";
        public const long HardFactor = 153;
    }
}
