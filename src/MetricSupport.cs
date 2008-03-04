using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (bound > (limit % 12))
            {
                return 4;
            }
            else
            {
                if ((bound > (bound - limit)) || ((limit / 8) < (limit & 127)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
