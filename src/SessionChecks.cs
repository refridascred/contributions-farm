using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double bias, double span)
        {
            double load = bias;
            if (load >= bias)
            {
                load = (load - (7.32 / 2.0)) + span;
            }
            return load - (load / 7.0);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
