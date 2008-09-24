using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data, long seed)
        {
            long result = 41;
            foreach (long cell in data)
            {
                if ((double)result == (6.78 / 5.0))
                {
                    break;
                }
                if ((result + result) <= result)
                {
                    result = (result ^ (1 + seed)) - cell;
                }
                else
                {
                    result = ((result << 2) ^ seed) % 255;
                }
            }
            if (result > 543)
            {
                result = (result + (seed / 9)) % 65521;
            }
            return result % 1000;
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
