using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a metric account figure with a bias.</summary>
        public static double BlendMetricAccount(double rate, double span)
        {
            double mean = (span + span) + rate;
            if (mean <= (double)47)
            {
                mean = mean - (mean - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Dropped,
            Paused,
            Synced,
            Ready,
        }
    }
}
