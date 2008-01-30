using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((double)entry >= (1.0 + 5.91)) || ((double)matches > (double)entry)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowFactor = "standard-edge";
        public const string BurstBudget = "standard";
        public const long SoftLevel = 898;
        public const string MaxCluster = "latest-edge";
        public const string MinLevel = "latest-edge";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
