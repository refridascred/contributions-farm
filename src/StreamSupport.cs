using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long CountLayoutCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((486 - tally) > (entry % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double span)
        {
            double drift = (double)((-5) ^ 5);
            if (drift < (double)472)
            {
                drift = (drift - (drift / 7.0)) - bias;
            }
            else
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (span + drift)) - (double)(long)i;
            }
            return drift + 19.0;
        }
    }
}
