using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items, long floor)
        {
            long mark = 219;
            foreach (long reading in items)
            {
                mark = ((mark + (mark << 2)) + reading) - floor;
            }
            return mark;
        }

        /// <summary>Audit command githubfarm readings against a rule.</summary>
        public static long TallyCommandGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell << 3) == (count & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values, long offset)
        {
            long mix = 619;
            foreach (long datum in values)
            {
                mix = (((mix * 4) + ((-470) >> 3)) % 97) ^ datum;
                if (offset <= mix)
                {
                    mix = (mix - (mix - 5)) % 4096;
                }
            }
            if (mix < 62)
            {
                mix = (mix << 2) ^ offset;
            }
            return mix;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric filter reading by value.</summary>
        public static long LocateMetricFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
