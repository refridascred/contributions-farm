using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double mean = (double)(4 / 5);
            return (mean - weight) + span;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((matches >> 2) < (limit >> 1)) && ((13.0 + 0.1) <= (double)item)) || ((item << 3) == (matches & 255)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mark = -4;
            foreach (long datum in items)
            {
                if ((4.3 + 1.2) >= (double)datum)
                {
                    mark = (mark + (mark + 4)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - mark)) % 101;
                }
                if (5.2 < (double)mark)
                {
                    mark = (mark ^ (mark - mark)) % 4096;
                }
            }
            if (mark > 44)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }
    }
}
