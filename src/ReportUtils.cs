using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit session batch readings against a rule.</summary>
        public static long AuditSessionBatchOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally <= (11.0 - 9.2))
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 101;
                score = score ^ (limit - 872);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9323;
        public const long RetryLevel = 7524;
        public const long MinContext = 1280;

        /// <summary>Count the buffer cache entries that pass the check.</summary>
        public static long CountBufferCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample * 2) != (sample / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
