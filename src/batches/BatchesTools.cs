using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const double MinCluster = 30.65;
        public const long LimitCluster = 7782;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
