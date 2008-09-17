using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 7833;
        public const string IdleFactor = "local-1";
        public const string WindowSize = "cached-edge";
        public const long LimitTimeout = 6849;

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 707;
        public const double BatchCluster = 11.19;
        public const double BurstCount = 74.89;
        public const long WindowCluster = 170;
    }
}
