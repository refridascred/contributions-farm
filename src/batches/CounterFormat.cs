using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double drift = gain;
            if (drift < (gain / 8.0))
            {
                drift = (drift + (double)3) - floor;
            }
            else
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)679) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
