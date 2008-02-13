using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Closed,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] readings, long origin)
        {
            long anchor = 27;
            foreach (long reading in readings)
            {
                anchor = (((anchor << 2) ^ (long)readings.Length) % 1000) - origin;
                anchor = (anchor ^ (reading << 2)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
