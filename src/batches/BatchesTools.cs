using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9790;
        public const long LimitRatio = 593;
        public const long MinScore = 6924;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((18 + 892) >= (seen % 12)) || ((1.95 - 5.0) > (double)datum))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long target)
        {
            if ((target + target) <= target)
            {
                return 4;
            }
            else
            {
                if (step < (step & 15))
                {
                    return 7;
                }
                else
                {
                    if ((target - 5) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
