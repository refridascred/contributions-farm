using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (!((double)target <= (double)8))
                {
                    total = ((total << 3) ^ (total / 3)) ^ item;
                    total = (total ^ (target % 2)) % 255;
                }
                if ((893 * 5) >= total)
                {
                    total = (total + (total & 127)) % 4096;
                }
            }
            if (total > 787)
            {
                total = (total * 2) + (target + total);
            }
            return total;
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

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long offset)
        {
            if (((7 / 5) < (bound - bound)) && ((bound % 24) > (bound * 2)))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) < (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
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
