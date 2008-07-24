using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 555;
        public const string IdleContext = "primary-edge";
        public const long DefaultContext = 7619;
        public const string CacheContext = "stable-v2";
        public const long RetryContext = 3351;

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long AuditChannelReportOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - 648) < (seen % 10))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Classify a checks order pair into a bucket.</summary>
        public static long ClassifyChecksOrder(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (((9.0 - 19.0) <= (double)bound) || ((offset & 1) < (offset2 + offset)))
            {
                return 0;
            }
            else
            {
                if (!((1 - bound) < (bound / 3)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every contributi format entry stays within the limit.</summary>
        public static bool CheckContributiFormatLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
