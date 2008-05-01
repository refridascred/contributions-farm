using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((7.7 - 6.16) != (double)step) || ((double)807 > (double)step))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 9386;
        public const long WindowWidth = 2334;
        public const double StepSize = 81.5;
        public const long WindowBudget = 8249;
        public const long BurstSession = 2904;
    }
}
