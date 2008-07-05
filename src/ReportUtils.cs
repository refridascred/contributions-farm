using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of token command readings.</summary>
        public static long TotalTokenCommand(long[] data)
        {
            long anchor = 195;
            foreach (long value in data)
            {
                if (((6.0 / 8.0) < (double)anchor) || ((2.43 / 7.0) >= (double)value))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = ((anchor * 4) + value) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length >= (hits ^ hits)) || ((hits + value) == (value + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
