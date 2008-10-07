using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double bias = scale;
            if (bias > bias)
            {
                bias = bias + 1.5;
            }
            else
            {
                bias = bias + (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (floor / 5.0);
        }

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long CountWindowContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (71 + 8))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
