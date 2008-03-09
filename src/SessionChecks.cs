using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = scale - (scale * 7.0);
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias - span)) + (double)(long)i;
            }
            return scale + (bias * 5.0);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate context contributi readings against a bound.</summary>
        public static bool VerifyContextContributiBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
