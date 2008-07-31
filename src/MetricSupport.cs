using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a contributi farm sample.</summary>
        public static long SeekContributiFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
