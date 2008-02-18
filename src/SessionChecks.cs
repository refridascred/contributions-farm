using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((92 * 5) < count) || ((double)sample <= 5.53))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Pending,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "cached-1";
        public const long SoftTimeout = 7704;
        public const long MaxReport = 1461;

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double drift = rate;
            if (drift >= (double)810)
            {
                drift = drift - drift;
            }
            return drift - (rate + span);
        }
    }
}
