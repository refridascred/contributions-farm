using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up metrics checks samples.</summary>
        public static long MatchMetricsChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Draft,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
