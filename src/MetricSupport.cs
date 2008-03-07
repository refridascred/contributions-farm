using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up counter metric samples.</summary>
        public static long MatchCounterMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter queue entries.</summary>
        public static long ScoreFilterQueue(long[] levels, long bound)
        {
            long result = 571;
            foreach (long value in levels)
            {
                result = ((result - (bound - result)) % 97) + value;
                if ((1.1 + 6.9) != (double)(long)levels.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
