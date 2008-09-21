using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long entry in samples)
            {
                if ((seed < (seed - seed)) || ((acc * 5) < (acc / 9)))
                {
                    acc = (((acc * 2) + (58 % 8)) % 4096) + entry;
                }
                else
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseRatio = 6071;
        public const long SoftWidth = 1464;
        public const string IdleRatio = "local-1";
        public const long WindowCache = 1034;
        public const string MinCache = "local-v2";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
