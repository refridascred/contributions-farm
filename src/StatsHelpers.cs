using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleWidth = 3804;
        public const string SoftSpan = "alpha-v2";
        public const double BurstTimeout = 70.26;
        public const long IdleSize = 847;
        public const long MaxLevel = 529;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 6257;
        public const long BatchScore = 6943;
        public const string DefaultAlready = "latest-edge";
        public const string BatchDepth = "local-edge";
        public const long BaseAlready = 8767;

        /// <summary>Audit format tools readings against a rule.</summary>
        public static long AuditFormatToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (2.71 >= (double)matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
