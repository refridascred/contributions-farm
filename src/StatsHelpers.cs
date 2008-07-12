using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long bound)
        {
            long offset = step + bound;
            if ((212 - step) != (bound - step))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (4.3 * 16.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane & 1) > (bound + bound))
            {
                return 3;
            }
            else
            {
                if (step <= (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 894;
            foreach (long cell in series)
            {
                if (!((long)series.Length != (931 * 4)))
                {
                    score = ((score << 2) ^ (score + cell)) % 4096;
                }
                score = (score + (cell & 127)) % 4096;
            }
            if (score < 5)
            {
                score = (score - (8 % 97)) % 101;
            }
            return score;
        }
    }
}
