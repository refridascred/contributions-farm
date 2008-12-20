using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate metric token samples.</summary>
        public static long FoldMetricToken(long[] values, long offset)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                if ((offset / 9) != (sample << 2))
                {
                    mark = (mark + (65 ^ offset)) % 97;
                }
                if (!(mark >= (offset + (-21))))
                {
                    mark = (mark ^ (offset - sample)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 9555;
        public const long CacheCounter = 1583;
        public const string IdleCount = "strict-1";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "primary";
        public const string DefaultCache = "latest-edge";
        public const double DefaultRatio = 55.27;
        public const long WindowCache = 3897;
    }
}
