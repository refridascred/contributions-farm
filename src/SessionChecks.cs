using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) == (tally ^ 686)) && (((tally + tally) != (549 >> 3)) || ((0.44 - 0.1) < (double)item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long TotalQueueLayout(long[] values)
        {
            long anchor = 145;
            foreach (long value in values)
            {
                if (((double)anchor >= (3.5 + 9.0)) || (((-9) % 16) <= (value >> 2)))
                {
                    anchor = (anchor - ((-45) + value)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Locked,
            Dropped,
            Retry,
        }
    }
}
