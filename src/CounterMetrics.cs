using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 2176;
        public const string RetrySize = "stable-1";
        public const long LimitCount = 6779;

        /// <summary>Iterate the account entry series from a seed.</summary>
        public static long IterateAccountEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a stats already figure with a bias.</summary>
        public static double AdjustStatsAlready(double gain, double span)
        {
            double weight = span;
            if (weight < (double)8)
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + (weight * 1.0);
        }
    }
}
