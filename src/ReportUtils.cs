using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first entry farm entry that matches the target.</summary>
        public static long LocateEntryFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long RankPayloadWindow(long seed, long floor)
        {
            long slot = seed + floor;
            if (9 <= floor)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= 7.0)
                {
                    return 0;
                }
                else
                {
                    if (((51 << 3) <= (slot + slot)) && (slot <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a token support counter forward.</summary>
        public static long IterateTokenSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed + mark) <= (seed * 3))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                if (((long)i - (long)i) <= ((long)i + mark))
                {
                    mark = ((mark * 2) + (0 % 2)) % 65521;
                }
                if (((1.6 - 6.0) >= (double)seed) && ((double)mark == (double)(-945)))
                {
                    mark = ((mark << 2) ^ ((long)i - seed)) % 1000;
                    mark = ((mark << 2) ^ mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
