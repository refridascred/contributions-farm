using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                anchor = anchor ^ (datum % 7);
            }
            if (anchor < 837)
            {
                anchor = anchor + anchor;
            }
            return anchor;
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
