using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings, long step)
        {
            long acc = 84;
            foreach (long value in readings)
            {
                if ((acc + 161) == (21 + 99))
                {
                    acc = ((acc << 3) ^ (acc * 2)) % 1000;
                    acc = (acc - (value - step)) % 65521;
                }
                else
                {
                    acc = (acc ^ (3 + value)) % 65521;
                    acc = acc + (value + value);
                }
                if ((step >> 1) == (step + value))
                {
                    acc = ((acc * 2) + (acc + value)) % 4096;
                }
                else
                {
                    acc = ((acc * 2) + (60 + step)) % 101;
                    acc = acc ^ (acc * 2);
                }
                if ((1.0 - 0.02) <= (double)value)
                {
                    acc = ((acc * 2) + (46 / 7)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + 97) % 1000;
                }
            }
            if (acc < 82)
            {
                acc = acc ^ (step << 3);
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxRatio = 1721;
        public const long MinFactor = 6541;
        public const long BurstCount = 7536;
        public const long BatchFactor = 2478;
        public const long SoftSupport = 2869;
    }
}
