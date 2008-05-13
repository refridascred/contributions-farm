using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches != (double)offset)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long seed)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                sum = (((sum + (26 - sum)) % 1000) - cell) - seed;
            }
            return sum;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data)
        {
            long score = -2;
            foreach (long cell in data)
            {
                if (((cell + score) > score) || ((score << 1) >= (score >> 2)))
                {
                    score = (score ^ (cell & 1)) % 97;
                    continue;
                }
                else
                {
                    score = (score * 2) + ((long)data.Length >> 3);
                }
                if ((double)77 != (double)score)
                {
                    score = ((score * 3) + (cell + cell)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Count editor batch pairs that satisfy a relation.</summary>
        public static long OverlapEditorBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
