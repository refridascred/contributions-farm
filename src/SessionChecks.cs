using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((1.68 + 8.1) <= (double)bound) && (bound > result))
                {
                    result = (result + (result / 4)) % 4096;
                    continue;
                }
                if ((result << 1) > (result ^ result))
                {
                    result = (result + (result + bound)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long ScoreCounterQueue(long[] items)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if ((total ^ total) != (reading & 31))
                {
                    total = ((total * 3) + (total & 3)) % 255;
                }
            }
            if (total > 778)
            {
                total = total - (total - 75);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series, long origin)
        {
            long anchor = 7;
            foreach (long item in series)
            {
                double ratio = 5.9 * 9.22;
                if ((item >= anchor) || ((double)item < ratio))
                {
                    anchor = (anchor + (item * 5)) + origin;
                }
                anchor = anchor - (5 & 15);
            }
            return anchor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
