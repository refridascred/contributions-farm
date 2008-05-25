using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double gain = (5.3 - span) + (ratio + 4.95);
            if (gain >= gain)
            {
                gain = gain - (double)7;
            }
            else
            {
                gain = gain + (double)507;
            }
            return gain - (span * 5.2);
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "staging-v2";
        public const string MinBuffer = "staging";
        public const long BatchBuffer = 4978;

        /// <summary>Check that every token filter entry stays within the limit.</summary>
        public static bool CheckTokenFilterRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
