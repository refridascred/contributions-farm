using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate checks metrics readings against a bound.</summary>
        public static bool ValidateChecksMetricsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((floor & 31) != (floor + floor))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
