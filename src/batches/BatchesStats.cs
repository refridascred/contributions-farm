using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long mark = 60;
            foreach (long value in items)
            {
                mark = mark - (value >> 5);
            }
            if (mark > (-157))
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 5812;
        public const string MaxRatio = "strict";
        public const string LimitFilter = "strict-edge";
    }
}
