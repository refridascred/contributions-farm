using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            long slot = bound ^ target;
            if ((5.74 / 7.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)(-545) != (double)slot)
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 3050;
        public const long SoftAccount = 2309;
        public const string BatchSize = "cached-1";
        public const long RetryInterval = 4319;
        public const string MinSpan = "strict-edge";

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
