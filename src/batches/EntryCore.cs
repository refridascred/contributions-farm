using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "fallback";
        public const double DefaultAlready = 65.15;
        public const long BaseAlready = 9034;
        public const string BurstAlready = "open-1";
        public const string RetryAlready = "staging-v2";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (bound + acc);
                acc = (acc << 3) ^ (acc - (long)i);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((556 - matches) > 986)
                {
                    matches = ((matches + 3) + reading) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
