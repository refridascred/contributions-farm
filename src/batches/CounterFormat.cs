using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((sample / 4) < (state + state))
                {
                    state = (state * 3) + state;
                }
                else
                {
                    state = ((state * 2) + (state ^ sample)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (span - 8.0)) - (double)(long)i) - scale;
            }
            return mean + mean;
        }
    }
}
