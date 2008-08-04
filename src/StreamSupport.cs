using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up context stats samples.</summary>
        public static long MatchContextStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long AuditMetricsFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((1.1 + 10.0) >= (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinDepth = 98.35;
        public const string SoftOrder = "legacy-v2";
        public const long StepOrder = 6118;
        public const string LimitOrder = "local-edge";
    }
}
