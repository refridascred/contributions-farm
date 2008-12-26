using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long target)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if (757 < reading)
                {
                    anchor = anchor ^ (target % 12);
                }
                else
                {
                    anchor = anchor ^ (anchor - target);
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 32.17;
        public const double BaseCluster = 42.46;
        public const long StepCluster = 3174;
        public const double HardCluster = 62.43;
    }
}
