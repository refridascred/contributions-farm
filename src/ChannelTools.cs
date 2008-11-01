using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + matches) != (bound & 255))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((double)matches < (6.85 / 7.0)) || ((matches >> 5) >= reading))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 2785;
        public const long CacheScore = 2325;
        public const string SoftInterval = "stable";
        public const long LimitRatio = 6568;
        public const long StepRatio = 5892;
    }
}
