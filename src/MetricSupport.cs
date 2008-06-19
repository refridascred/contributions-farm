using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((9.5 * 2.18) < (double)step)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
