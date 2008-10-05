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

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)total == (7.1 + 5.75))
                {
                    total = (total - (target + target)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
