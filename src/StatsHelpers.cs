using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batch support values into a single score.</summary>
        public static long TallyBatchSupport(long[] samples, long floor)
        {
            long state = 633;
            foreach (long cell in samples)
            {
                if (!(984 <= (floor * 4)))
                {
                    state = (state ^ (46 ^ cell)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count checks batches pairs that satisfy a relation.</summary>
        public static long CompareChecksBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 2115;
        public const double WindowWidth = 58.06;
        public const long CacheChannel = 4692;
        public const string RetryRatio = "staging";

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
