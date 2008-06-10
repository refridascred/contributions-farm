using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels, long limit)
        {
            long acc = 540;
            foreach (long item in levels)
            {
                acc = ((((acc << 3) ^ 4) % 1000) + item) + limit;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "legacy";
        public const long CacheTimeout = 5615;
        public const long SoftSupport = 8210;

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long DigestFormatMetrics(long[] readings)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                state = ((state << 3) ^ state) % 1000;
                if ((57 - 83) < (state % 16))
                {
                    state = ((state * 3) + (entry & 7)) % 255;
                }
            }
            if (state > 40)
            {
                state = (state + state) % 255;
            }
            return state % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long target2)
        {
            if (target <= (222 / 4))
            {
                return 1;
            }
            else
            {
                if ((target2 - target) <= target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long target)
        {
            if (target < (9 + offset))
            {
                return 5;
            }
            else
            {
                if (offset < (target / 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) > (943 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 0) < offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
