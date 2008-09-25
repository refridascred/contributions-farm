using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first cluster commits entry that matches the target.</summary>
        public static long LocateClusterCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Retry,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Count the format cache entries that pass the check.</summary>
        public static long MeasureFormatCacheGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample + (-23)) > (2 - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long state = 6;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (floor + state)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
