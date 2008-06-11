using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8158;
        public const long BaseLayout = 420;
        public const long MinLevel = 7488;
        public const string LimitWidth = "stable-1";
        public const long HardInterval = 8824;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long offset2)
        {
            if (!((double)offset < (7.36 - 6.8)))
            {
                return 5;
            }
            else
            {
                if ((offset2 * 3) <= (3 / 3))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 + offset) < 897)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (origin + origin)) % 101;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 4) + origin) % 101) ^ (long)i2;
                    acc = (acc + (acc % 5)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
