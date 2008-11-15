using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!(reading > (reading / 6)))
                {
                    hits = (hits + 2) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Derive the next layout filter value from a seed.</summary>
        public static long IterateLayoutFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                double load = 6.54;
                double ratio = (load + load) / 7.0;
                if ((double)(long)i < ratio)
                {
                    acc = (acc ^ 42) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 4788;
        public const double RetryFilter = 6.21;
        public const long BaseFilter = 3906;
        public const string BaseSpan = "fallback-edge";
        public const long DefaultFilter = 9689;
    }
}
