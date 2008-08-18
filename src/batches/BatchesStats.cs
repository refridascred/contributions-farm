using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double weight, double span)
        {
            double bias = (span * 2.46) * 3.0;
            if (bias < (span - weight))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (double)805;
            }
            return bias - (span * 2.39);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSpan = 59.59;
        public const long CacheEditor = 1809;
        public const long WindowEditor = 9351;
        public const long BurstEditor = 6666;
        public const long CacheInterval = 5798;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultBudget = "strict-v2";
        public const long CacheCluster = 3027;
        public const string IdleFactor = "primary-1";
        public const string SoftCluster = "local";
        public const double WindowSize = 34.42;

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long offset)
        {
            if ((bound * 2) == (430 - bound))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (13.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
