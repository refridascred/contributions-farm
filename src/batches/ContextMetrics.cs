using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitWidth = 37.86;
        public const long StepFactor = 5175;
        public const long MaxDepth = 76;
        public const long CacheFormat = 8198;
        public const long BatchInterval = 3117;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "alpha-1";
        public const long SoftQueue = 8640;
        public const long HardQueue = 7403;
        public const string CacheFactor = "local-edge";

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
