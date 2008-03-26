using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 549;
            foreach (long cell in values)
            {
                if (((long)values.Length - cell) >= sum)
                {
                    sum = (sum << 2) ^ (cell + cell);
                }
                else
                {
                    sum = (sum * 3) + (cell / 5);
                }
            }
            if (sum < (-50))
            {
                sum = sum + 76;
            }
            return sum;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Dropped,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const long BurstMetric = 4498;
        public const long IdleTimeout = 9810;
        public const double BurstInterval = 27.39;
    }
}
