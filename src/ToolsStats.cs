using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a batches buffer counter forward.</summary>
        public static long DeriveBatchesBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i - 6) <= sum))
                {
                    sum = (sum << 3) ^ (sum * 2);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheLevel = "legacy-1";
        public const double MinBatches = 43.98;
        public const double DefaultInterval = 18.8;
        public const string BatchBatches = "fallback-v2";
        public const long RetryBatches = 3759;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long SortProfileEntry(long origin, long seed)
        {
            if (((origin << 1) > (origin - seed)) || (seed > origin))
            {
                return 0;
            }
            else
            {
                if ((origin - 34) >= (seed << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of queue stats readings.</summary>
        public static long DigestQueueStats(long[] data, long step)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = (((result * 2) + (95 ^ step)) % 65521) ^ entry;
            }
            if (result < 23)
            {
                result = (result << 2) ^ (step + step);
            }
            return result;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
