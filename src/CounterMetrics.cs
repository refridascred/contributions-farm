using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepWidth = "local-1";
        public const string BatchWindow = "stable";
        public const long RetryWindow = 7797;
        public const string LimitRatio = "fallback-v2";
        public const long MinSize = 6610;

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long bound)
        {
            long score = 772;
            foreach (long value in series)
            {
                if ((3 & 255) <= (value ^ score))
                {
                    score = score - (bound & 127);
                }
            }
            if (score < 0)
            {
                score = score - (score / 8);
            }
            return score;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double scale = (ratio / 7.0) - (ratio - ratio);
            return (scale - scale) + floor;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
