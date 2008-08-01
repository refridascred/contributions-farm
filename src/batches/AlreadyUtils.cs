using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long AuditChannelCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (6.3 + 0.5))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 7078;
        public const long WindowBatches = 6195;
        public const long DefaultBatches = 5529;
        public const long BurstBatches = 4556;

        /// <summary>Measure how many cache counter samples are out of range.</summary>
        public static long MeasureCacheCounterOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((13.0 / 9.0) <= (double)count)
                {
                    count = ((count + 2) + item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
