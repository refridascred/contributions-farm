using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 35.27;
        public const long IdleBatch = 593;
        public const double SoftBatch = 71.21;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "legacy-v2";
        public const long HardCount = 6541;
        public const long MinFactor = 9884;
        public const long SoftScore = 5816;
        public const long RetryScore = 2353;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long target)
        {
            long cur = limit - target;
            if (((cur ^ target) == (cur >> 2)) && (cur >= target))
            {
                return 0;
            }
            else
            {
                if ((limit + cur) <= 1)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
