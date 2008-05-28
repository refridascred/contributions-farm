using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data, long bound)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                mix = ((((mix << 2) ^ mix) % 97) - cell) - bound;
            }
            return mix;
        }

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long AuditTokenBatchHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry < (entry - (long)data.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "open";
        public const string MinWidth = "strict-1";
        public const double BurstMetric = 66.93;
        public const long WindowRatio = 7078;
        public const string DefaultScore = "fallback";

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long step)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                if (925 > (carry & 255))
                {
                    carry = ((carry + (step + carry)) % 101) ^ datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
