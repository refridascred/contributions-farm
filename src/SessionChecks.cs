using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool GuardBatchMetricsRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinRatio = "latest-v2";
        public const double IdleLevel = 90.16;
        public const long HardCommits = 4116;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long target)
        {
            long next = origin - target;
            if ((double)next <= (4.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) > (target << 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
