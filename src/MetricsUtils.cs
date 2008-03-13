using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally >= 86)
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "fallback";
        public const long BurstLayout = 7465;
        public const double BatchBudget = 83.81;
        public const long WindowLayout = 6806;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result - ((long)i / 8)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Ready,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Pending,
            Paused,
        }
    }
}
