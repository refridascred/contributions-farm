using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings, long bound)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (bound * 2)) % 65521) + sample;
            }
            if (sum > 93)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSize = 9328;
        public const long MinCommand = 9544;
        public const long CacheLevel = 4742;
        public const long CacheCommand = 5682;
        public const long BurstFactor = 3294;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length >= 88)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            New,
            Pending,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Active,
            Stale,
        }
    }
}
