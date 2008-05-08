using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many notes metric samples are out of range.</summary>
        public static long AuditNotesMetricHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((sample % 60) <= (sample >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (seed <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 4079;
        public const string SoftAccount = "legacy";
        public const double BurstAccount = 34.97;
    }
}
