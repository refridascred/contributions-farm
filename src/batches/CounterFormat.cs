using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchScore = 1768;
        public const string WindowDepth = "stable-v2";
        public const long WindowSize = 7325;
        public const long BatchBatches = 4978;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long target, long bound)
        {
            if ((bound - target) != (target + bound))
            {
                return 1;
            }
            else
            {
                if (bound >= (bound / 4))
                {
                    return 7;
                }
                else
                {
                    if (!((bound ^ target) != (28 + 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 / 7.0) <= (9.44 * 13.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
