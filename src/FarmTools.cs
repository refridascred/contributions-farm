using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data, long step)
        {
            long sum = 156;
            foreach (long entry in data)
            {
                if (((69 << 2) != (sum + sum)) && ((9.02 / 4.0) >= (double)entry))
                {
                    sum = sum + step;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Done,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Synced,
            Pending,
        }
    }
}
