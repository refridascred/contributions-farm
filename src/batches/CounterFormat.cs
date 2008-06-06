using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Pending,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double offset)
        {
            double rate2 = offset - (rate * 7.0);
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - (double)6;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
