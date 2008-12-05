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

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepScore = "alpha-edge";
        public const long MinScore = 646;
        public const long MaxCommits = 9643;
        public const long StepDepth = 526;

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
