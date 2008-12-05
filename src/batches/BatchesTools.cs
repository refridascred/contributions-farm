using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2058;
        public const long MinSession = 7974;
        public const long SoftSpan = 7865;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
