using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count context cache pairs that satisfy a relation.</summary>
        public static long MatchContextCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits >> 1) != (hits - sample)) && ((double)hits == (2.89 - 2.0))))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long limit)
        {
            long score = 914;
            foreach (long entry in values)
            {
                long count = limit;
                if ((5.12 - 0.9) <= (double)count)
                {
                    score = ((score * 2) + ((long)values.Length ^ 44)) ^ entry;
                }
                score = ((score << 2) ^ (score * 2)) % 4096;
            }
            return score % 4096;
        }
    }
}
