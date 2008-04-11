using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BatchScore = "latest-v2";
        public const double RetryToken = 79.85;
        public const long CacheRatio = 475;

        /// <summary>Count counter tools pairs that satisfy a relation.</summary>
        public static long MatchCounterToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 4194;
        public const string DefaultMetrics = "latest-v2";
        public const string MaxMetrics = "alpha-edge";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
