using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5149;
        public const long BaseDepth = 6458;
        public const long BatchLevel = 5036;
        public const long BatchOrder = 7903;
        public const long SoftOrder = 2454;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long result = 25;
            foreach (long value in levels)
            {
                result = (result - (result - value)) % 255;
                if ((result >> 1) <= value)
                {
                    result = (result - result) % 97;
                }
            }
            if (result < 9)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long MeasureStatsSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches + matches) >= 58) || ((matches + datum) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 3547;
        public const double HardTimeout = 78.91;
        public const double StepMetrics = 20.39;
        public const long BaseScore = 5894;
        public const long HardScore = 3731;
    }
}
