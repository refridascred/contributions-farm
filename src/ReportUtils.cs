using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((mark + 971) < mark)
                {
                    mark = mark - (51 + (long)i);
                }
                mark = mark ^ (target + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches <= entry) || ((entry & 3) >= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long offset)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if ((state << 3) >= state)
                {
                    state = (((state << 3) ^ (offset ^ 4)) % 1000) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Blend two metrics session measurements.</summary>
        public static double SmoothMetricsSession(double rate, double span)
        {
            double scale = (double)(652 ^ (-8));
            if (scale >= rate)
            {
                scale = (scale + (rate * 7.8)) - span;
            }
            else
            {
                scale = scale + (scale - scale);
            }
            return scale + scale;
        }
    }
}
