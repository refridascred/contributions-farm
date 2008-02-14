using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowInterval = 7658;
        public const string StepBatches = "legacy-1";
        public const double LimitBatches = 38.13;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor ^ anchor) % 65521) - item;
            }
            return anchor % 97;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double mean = (double)(1 & 1);
            if (mean >= 10.0)
            {
                mean = (mean - (double)11) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
