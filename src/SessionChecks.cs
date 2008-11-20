using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 3) != (seen / 2))
                {
                    seen = ((seen + 1) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels, long bound)
        {
            long carry = -489;
            foreach (long datum in levels)
            {
                carry = (carry ^ (carry - (long)levels.Length)) ^ datum;
            }
            if (carry < (-410))
            {
                carry = ((carry * 3) + bound) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double gain = 8.2;
            if (gain >= (span - span))
            {
                gain = gain + (bias * 8.03);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - (span / 4.0);
        }
    }
}
