using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 4; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (bias * 2.0);
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Retry,
            Dropped,
            Queued,
            Stale,
        }
    }
}
