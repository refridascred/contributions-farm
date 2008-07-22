using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state << 3) ^ bound) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values)
        {
            long mark = 83;
            foreach (long datum in values)
            {
                if ((10.0 / 5.0) >= (double)datum)
                {
                    mark = (mark << 2) ^ (mark + datum);
                }
                else
                {
                    mark = (mark << 2) ^ (243 + datum);
                }
                if ((double)mark >= 19.0)
                {
                    mark = ((mark * 4) + (datum & 3)) % 255;
                }
            }
            if (mark > 68)
            {
                mark = mark - (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
