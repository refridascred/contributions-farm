using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry queue entry stays within the limit.</summary>
        public static bool CheckEntryQueueLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinLevel = 3734;
        public const string SoftTimeout = "standard-edge";
        public const long BurstFarm = 3486;
        public const long SoftFarm = 4628;

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double bias = 9.7;
            if (bias > (double)69)
            {
                bias = (bias + (5.25 * 9.22)) - weight;
            }
            return bias - (span / 9.0);
        }
    }
}
