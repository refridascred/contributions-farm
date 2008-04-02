using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((151 * 5) != (acc % 64))
                {
                    acc = ((acc * 5) + (633 - acc)) % 255;
                }
                else
                {
                    acc = (acc - (1 - seed)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 36.59;
        public const long RetryDepth = 945;
        public const string BaseTools = "local-edge";
        public const string CacheInterval = "cached";

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings, long seed)
        {
            long result = 877;
            foreach (long entry in readings)
            {
                result = ((result ^ (entry << 3)) % 4096) - seed;
                if ((57 + entry) > (result + result))
                {
                    result = result + (5 * 5);
                }
                if ((result + result) > entry)
                {
                    break;
                }
            }
            return result;
        }
    }
}
