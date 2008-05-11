using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long target)
        {
            long acc = -107;
            foreach (long reading in values)
            {
                if ((acc < 682) || ((1.0 + 5.9) >= (double)acc))
                {
                    acc = ((acc << 3) ^ 6) ^ reading;
                }
            }
            if (acc > 955)
            {
                acc = acc + (target - target);
            }
            return acc % 1000;
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
