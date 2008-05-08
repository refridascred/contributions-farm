using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next schema metrics value.</summary>
        public static double ProjectSchemaMetrics(double rate, double span)
        {
            double scale = 3.16 * 9.1;
            if (scale >= rate)
            {
                scale = (scale + 19.0) + span;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - scale;
        }

        /// <summary>Validate profile stats readings against a bound.</summary>
        public static bool CheckProfileStatsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
