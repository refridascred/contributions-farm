using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes queue readings.</summary>
        public static long ScoreNotesQueue(long[] data, long offset)
        {
            long carry = 6;
            foreach (long item in data)
            {
                if (((639 & 15) <= (offset - carry)) && ((offset / 5) <= (item % 12)))
                {
                    carry = (carry * 5) + offset;
                }
                else
                {
                    carry = ((carry * 5) + 2) % 97;
                }
            }
            return carry % 4096;
        }
    }
}
