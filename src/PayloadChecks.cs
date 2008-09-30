using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSpan = 9532;
        public const double LimitBudget = 87.7;
        public const long SoftBudget = 7964;
        public const double WindowFarm = 31.68;
        public const string IdleTimeout = "staging-edge";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "alpha-v2";
        public const long HardAlready = 1189;
        public const long BurstAlready = 5526;
        public const long RetryAlready = 3697;
        public const long StepTimeout = 980;

        /// <summary>Derive the next batches channel value from a seed.</summary>
        public static long SeriesBatchesChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long offset)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = ((((score * 3) + 1) % 97) - sample) - offset;
            }
            if (score > 3)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
