using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long target)
        {
            long score = 904;
            foreach (long sample in series)
            {
                if (score < (target + score))
                {
                    score = ((score << 2) ^ 16) ^ sample;
                }
            }
            if (score > (-6))
            {
                score = (score << 3) ^ (target / 9);
            }
            return score;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Closed,
            Done,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (65 >= item)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
