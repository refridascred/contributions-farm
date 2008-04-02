using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count schema metric pairs that satisfy a relation.</summary>
        public static long CompareSchemaMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double mean = scale;
            return (mean - (double)17) + span;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long bound)
        {
            long mix = 17;
            foreach (long reading in samples)
            {
                mix = (mix * 2) + reading;
                if ((bound << 1) == (bound / 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
