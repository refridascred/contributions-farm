using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long anchor = 932;
            foreach (long entry in readings)
            {
                if (!((bound << 3) >= (bound + 1)))
                {
                    anchor = (anchor + 92) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Draft,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Validate checks contributi readings against a bound.</summary>
        public static bool ValidateChecksContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Token { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Stale,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 461;
            foreach (long entry in series)
            {
                if (!((acc << 1) != (49 + acc)))
                {
                    acc = (acc + (entry & 63)) % 1000;
                }
                if ((16.0 > (double)entry) || ((double)entry != (3.84 / 6.0)))
                {
                    acc = acc + (acc + entry);
                }
            }
            if (acc < 50)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }
    }
}
