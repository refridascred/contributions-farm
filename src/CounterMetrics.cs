using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Iterate the notes format series from a seed.</summary>
        public static long IterateNotesFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((anchor >> 2) >= (anchor + (long)i))
                {
                    anchor = anchor - (long)i;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (limit - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long score = 84;
            foreach (long sample in levels)
            {
                score = (score ^ (1 + sample)) % 101;
                if ((sample + sample) < (score * 5))
                {
                    score = ((score * 2) + (sample + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long floor)
        {
            if ((38 >> 1) <= (bound >> 3))
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.3) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
