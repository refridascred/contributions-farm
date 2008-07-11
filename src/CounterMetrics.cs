using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Queued,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Audit command queue readings against a rule.</summary>
        public static long MeasureCommandQueueOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2 - tally) != (tally & 63))
                {
                    tally = ((tally + 2) ^ item) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
