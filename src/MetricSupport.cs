using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool GuardClusterNotesLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long step)
        {
            if ((9.5 * 1.2) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((5.9 - 0.71) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseRatio = 1784;
        public const string BaseWindow = "local-edge";
        public const long SoftWindow = 3589;
    }
}
