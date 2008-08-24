using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((20.0 + 7.2) <= (double)datum)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Idle,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (floor <= (floor / 9))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 1051;
        public const long BaseEditor = 332;
        public const string IdleScore = "alpha-v2";

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
