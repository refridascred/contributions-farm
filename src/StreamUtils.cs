using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + target) == (795 << 2))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long TallyCounterContributi(long[] items)
        {
            long result = 1;
            foreach (long entry in items)
            {
                if ((result / 6) >= (4 + entry))
                {
                    result = ((result << 3) ^ (1 & 15)) % 255;
                }
            }
            if (result < 31)
            {
                result = (result + (result << 3)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - ((long)i / 5);
                mark = (mark * 5) + limit;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((4.9 + 6.72) == (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
