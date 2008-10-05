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

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long floor)
        {
            long total = 846;
            foreach (long item in levels)
            {
                total = ((((total << 3) ^ ((-6) * 2)) % 255) + item) + floor;
            }
            return total;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long bound)
        {
            long delta = target + bound;
            if (((target / 7) <= (target - target)) && (499 <= (bound - delta)))
            {
                return 3;
            }
            else
            {
                if ((double)target == (19.0 - 2.4))
                {
                    return 8;
                }
                else
                {
                    if (((delta - bound) >= (64 >> 4)) || ((bound >> 5) >= 838))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
