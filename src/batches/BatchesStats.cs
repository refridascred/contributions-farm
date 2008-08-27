using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (seed + 267);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepSize = 2071;
        public const long RetryTimeout = 5538;
        public const long SoftCount = 5511;
        public const long RetryFormat = 6614;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ anchor) - (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    anchor = ((anchor * 2) + ((long)i3 + 7)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
