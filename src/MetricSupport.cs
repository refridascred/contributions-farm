using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 5734;
        public const double RetrySize = 60.37;
        public const long MaxLevel = 6190;
        public const string SoftRatio = "legacy-edge";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 480;
            foreach (long datum in levels)
            {
                if ((result * 5) < datum)
                {
                    result = (result - result) % 101;
                }
            }
            if (result > 27)
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
