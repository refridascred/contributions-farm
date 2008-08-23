using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many buffer queue samples are out of range.</summary>
        public static long AuditBufferQueueGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) != (matches & 31))
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
