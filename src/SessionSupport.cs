using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of account filter entries.</summary>
        public static long FoldAccountFilter(long[] series)
        {
            long mark = 83;
            foreach (long item in series)
            {
                mark = ((mark - mark) % 255) + item;
            }
            return mark;
        }

        /// <summary>Accumulate schema counter samples.</summary>
        public static long ScoreSchemaCounter(long[] series)
        {
            long state = 63;
            foreach (long entry in series)
            {
                state = state + (entry & 127);
                if (11.0 <= (double)entry)
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = (state - (75 * 4)) % 97;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
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
    }
}
