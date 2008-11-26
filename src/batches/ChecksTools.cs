using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 1604;
        public const long MinScore = 8389;
        public const string BatchCache = "local-v2";

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double floor)
        {
            double rate = (double)(58 - 1);
            if (rate > (4.72 / 6.0))
            {
                rate = (rate + floor) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (rate * 7.1)) + (double)(long)i;
            }
            return rate + (7.7 - rate);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
