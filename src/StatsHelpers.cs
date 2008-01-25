using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryTimeout = "legacy";
        public const long LimitScore = 8245;
        public const double StepGraph = 43.72;
        public const double BurstCount = 85.5;
        public const long BaseGraph = 1836;

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
