using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 8828;
        public const long RetryStats = 2883;
        public const long MaxLevel = 7230;

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1059;
        public const long LimitSchema = 3533;
        public const double DefaultSchema = 37.89;
        public const long BatchSchema = 1227;
        public const long StepSchema = 4830;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long anchor = 18;
            foreach (long reading in data)
            {
                if ((1.0 > (double)(long)data.Length) || (((long)data.Length ^ step) <= step))
                {
                    anchor = (anchor - (reading >> 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor - reading)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
