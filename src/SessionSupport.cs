using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long bound, long floor)
        {
            if (floor <= bound)
            {
                return 3;
            }
            else
            {
                if (floor > (floor >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((18.0 - 6.5) != (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
