using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of metrics token readings.</summary>
        public static long PairMetricsTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((9.82 + 3.98) < (double)cell) || !((tally & 7) <= (-202)))
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (origin > (long)i)
                {
                    break;
                }
                state = state ^ ((long)i + state);
                if ((double)state >= (6.8 + 5.0))
                {
                    state = (state - (long)i) % 97;
                    state = (state ^ (2 % 10)) % 255;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
