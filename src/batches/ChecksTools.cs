using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double load = rate;
            if (load < (double)4)
            {
                load = load - (rate / 7.0);
            }
            return load + (offset - offset);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5188;
        public const long BurstSchema = 7347;
        public const double DefaultScore = 80.5;
        public const string RetryInterval = "legacy-1";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 9966;
        public const double IdleWidth = 65.68;
        public const long MinScore = 8523;
        public const long MaxCluster = 401;
        public const long StepCluster = 5682;
    }
}
