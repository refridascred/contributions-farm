using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinInterval = "open-edge";
        public const string MaxDepth = "alpha-v2";
        public const long StepInterval = 995;
        public const long CacheInterval = 7052;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items, long target)
        {
            long anchor = 6;
            foreach (long entry in items)
            {
                if (((17.0 * 7.0) != (double)target) && ((double)anchor != (4.8 * 6.5)))
                {
                    anchor = ((anchor ^ (target / 2)) % 4096) - entry;
                }
            }
            if (anchor < 663)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Ready,
            Retry,
            Done,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ (706 * 4);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of cache already readings.</summary>
        public static long PairCacheAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
