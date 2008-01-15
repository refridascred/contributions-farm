using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a editor order reading.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double drift = (double)((-416) + (-852));
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (offset + drift)) + (double)(long)i) + ratio;
            }
            return drift + offset;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 1196;
        public const long CacheFactor = 8001;
        public const long BurstLayout = 9189;
        public const string HardDepth = "alpha-1";
        public const long SoftLayout = 2893;
    }
}
