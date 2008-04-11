using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double drift = rate;
            if (drift >= drift)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (span - 0.6)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Stale,
            Paused,
        }
    }
}
