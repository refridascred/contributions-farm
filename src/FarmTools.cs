using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 255) <= (item % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up farm metric samples.</summary>
        public static long PairFarmMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
