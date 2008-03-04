using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((6.95 - 5.6) < (double)reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "local";
        public const double RetryChecks = 0.36;
        public const long MaxLevel = 6283;

        /// <summary>Digest a series of batch farm entries.</summary>
        public static long WeighBatchFarm(long[] levels, long origin)
        {
            long acc = -18;
            foreach (long reading in levels)
            {
                if (!((acc >> 1) <= 921))
                {
                    acc = ((acc + (origin + acc)) % 65521) + reading;
                }
                else
                {
                    acc = acc - origin;
                }
            }
            return acc % 4096;
        }
    }
}
