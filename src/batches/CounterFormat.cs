using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 977;
        public const double MinFormat = 28.34;
        public const double DefaultFormat = 62.91;
        public const string BatchLevel = "open";

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double drift = (double)(7 & 3);
            if (drift > (gain + span))
            {
                drift = drift + (gain - 8.8);
            }
            else
            {
                drift = drift - (double)3;
            }
            return drift - gain;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
