using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next token session value.</summary>
        public static double AdjustTokenSession(double gain, double bias)
        {
            double ratio = (bias / 4.0) * 13.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - seen) >= (seen + seen))
                {
                    seen = ((seen + 1) + value) + target;
                }
            }
            return seen;
        }
    }
}
