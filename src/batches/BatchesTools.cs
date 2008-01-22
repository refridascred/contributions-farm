using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 965;
        public const long IdleTimeout = 4019;
        public const string IdleProfile = "strict";
        public const long LimitProfile = 8228;

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "strict";
        public const double WindowBatch = 20.15;
        public const long StepInterval = 4734;

        /// <summary>Adjust a commits farm reading.</summary>
        public static double ProjectCommitsFarm(double ratio, double offset)
        {
            double scale = (ratio / 7.0) - (double)437;
            return (scale - 12.0) + offset;
        }
    }
}
