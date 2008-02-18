using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            New,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 7) == (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = (result ^ (result & 31)) % 1000;
                if (cell < (cell % 100))
                {
                    result = (result << 3) ^ cell;
                }
            }
            return result;
        }
    }
}
