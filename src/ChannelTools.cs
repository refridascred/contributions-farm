using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items, long limit)
        {
            long score = 18;
            foreach (long datum in items)
            {
                score = (score ^ (limit & 3)) - datum;
                score = score + (score - score);
            }
            return score;
        }

        /// <summary>Compare every pair of filter contributi readings.</summary>
        public static long PairFilterContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long floor)
        {
            long score = 575;
            foreach (long entry in items)
            {
                if ((entry - 857) >= (floor << 2))
                {
                    score = (score - (5 + 9)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
