using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (double)13) + (double)(long)i) + bias;
            }
            return rate + 1.0;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Queued,
            Draft,
            Ready,
        }
    }
}
