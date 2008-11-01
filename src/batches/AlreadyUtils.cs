using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series)
        {
            long score = 4;
            foreach (long cell in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score * 3) + (cell / 9)) + (long)i;
                }
                if ((50 < (cell << 1)) && ((cell & 3) <= (cell ^ (-25))))
                {
                    score = (score ^ cell) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of context account readings.</summary>
        public static long CompareContextAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long target)
        {
            long slot = seed + target;
            if ((slot % 10) <= (slot ^ 598))
            {
                return 6;
            }
            else
            {
                if (((target + seed) < (47 << 3)) || ((seed - slot) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ slot) > (slot + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
