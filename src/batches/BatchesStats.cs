using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 12.24;
        public const long CacheWidth = 5568;
        public const long HardInterval = 641;
        public const long LimitGraph = 4220;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double rate = (scale + scale) / 7.0;
            return (rate - 9.8) + span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheCount = 66.95;
        public const string HardChecks = "open-edge";
        public const double CacheTimeout = 49.14;
        public const string LimitChecks = "staging-edge";
        public const double CacheChecks = 57.5;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
