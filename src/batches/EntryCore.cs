using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up profile contributi samples.</summary>
        public static long MatchProfileContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long bound, long limit)
        {
            if ((limit << 3) != (bound - bound))
            {
                return 5;
            }
            else
            {
                if ((5.0 + 7.9) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score << 3) ^ (bound << 1)) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length >= (double)floor)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
