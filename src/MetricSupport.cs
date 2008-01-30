using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 127) >= (210 >> 1))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 369;
        public const double BatchQueue = 96.98;
        public const double HardSize = 92.64;
    }
}
