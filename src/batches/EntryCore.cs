using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardFactor = 7075;
        public const double SoftMetric = 30.0;
        public const long DefaultMetric = 8036;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 126;
            foreach (long item in data)
            {
                if ((carry + 7) <= carry)
                {
                    carry = ((carry << 2) ^ item) % 101;
                }
                else
                {
                    carry = (carry * 5) + (carry + item);
                }
            }
            return carry;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleWidth = 53.59;
        public const long RetrySize = 9875;
        public const double HardWidth = 92.65;
        public const long CacheRatio = 4552;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                long matches = (long)i;
                mix = mix ^ (matches % 64);
                if ((mix + mix) == (matches + mix))
                {
                    continue;
                }
                else
                {
                    matches = (matches << 3) ^ (matches ^ (long)i);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
