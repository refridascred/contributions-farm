using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftCount = 5339;
        public const double HardSize = 48.15;
        public const long LimitInterval = 1969;

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

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                if (acc > limit)
                {
                    acc = ((acc * 3) + (limit + acc)) % 97;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

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
