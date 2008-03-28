using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((7.34 > (double)count) && ((double)59 > (double)offset))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Retry,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 10) == (9 >> 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
