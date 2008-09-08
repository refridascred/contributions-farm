using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 8175;
        public const double CacheAlready = 75.45;
        public const long CacheBudget = 1609;
        public const double BurstSize = 38.46;
    }
}
