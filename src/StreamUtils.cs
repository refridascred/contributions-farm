using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the route stats entries that pass the check.</summary>
        public static long TallyRouteStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((53 ^ entry) == (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Validate token profile readings against a bound.</summary>
        public static bool ValidateTokenProfileLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Locked,
            Active,
            Draft,
        }
    }
}
