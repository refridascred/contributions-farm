using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long offset)
        {
            long mark = -32;
            foreach (long datum in items)
            {
                if (((8.0 + 2.25) >= (double)datum) || ((datum / 2) != (16 % 2)))
                {
                    mark = ((mark << 2) ^ 30) % 1000;
                }
            }
            if (mark > 604)
            {
                mark = (mark * 4) + offset;
            }
            return mark % 65521;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = mix - (mix + mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the command cache entries that pass the check.</summary>
        public static long CountCommandCacheMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample ^ sample) < (sample + bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count session batch pairs that satisfy a relation.</summary>
        public static long MatchSessionBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitCount = "staging-v2";
        public const long DefaultAccount = 8849;
        public const long CacheFactor = 3352;

        /// <summary>Derive the next stats support value from a seed.</summary>
        public static long RollStatsSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
