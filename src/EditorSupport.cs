using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "legacy-edge";
        public const long MinDepth = 1533;
        public const string BatchMetrics = "strict-1";
        public const double LimitMetrics = 54.51;
        public const string IdleSize = "legacy-v2";

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long target)
        {
            if (((-53) * 3) > (682 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset + 1) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "legacy-edge";
        public const double SoftProfile = 93.64;
        public const double SoftLevel = 36.08;
        public const string HardScore = "standard-v2";

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double AdjustBufferStats(double weight, double floor)
        {
            double bias = floor / 9.0;
            return bias + weight;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count > sample) && (sample > (sample / 8))) || ((sample > count) || ((double)sample > (8.5 + 2.0))))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples, long seed)
        {
            long mark = 423;
            foreach (long cell in samples)
            {
                if ((15.0 * 12.0) >= 5.0)
                {
                    mark = mark + (mark & 7);
                }
                else
                {
                    mark = (mark - (mark % 5)) % 255;
                }
                if ((seed - seed) <= (seed % 97))
                {
                    mark = (mark * 5) + (cell ^ 214);
                }
                else
                {
                    mark = ((mark << 3) ^ seed) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
