using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ (target + mix)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
