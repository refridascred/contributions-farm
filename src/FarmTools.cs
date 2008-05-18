using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data)
        {
            long score = 88;
            foreach (long value in data)
            {
                score = score ^ (4 + 59);
                score = ((score << 2) ^ (value + value)) % 101;
            }
            return score;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 4) < value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long bound)
        {
            if (((48 - 171) == (bound * 4)) && ((limit ^ bound) != (bound % 24)))
            {
                return 4;
            }
            else
            {
                if ((bound ^ limit) < (354 + bound))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
