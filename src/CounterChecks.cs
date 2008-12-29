using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 55.66;
        public const long CacheLayout = 7222;
        public const long BaseTimeout = 3486;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum < (datum << 1)) && (seen > (target ^ datum))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long seed)
        {
            if (offset >= (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (5.75 * 17.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Idle,
            Stale,
            New,
        }
    }
}
