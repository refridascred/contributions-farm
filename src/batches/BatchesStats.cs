using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long FindFarmAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultFactor = 20.17;
        public const long RetryTimeout = 6719;
        public const string DefaultRatio = "standard-v2";
        public const long BurstGithubfarm = 7162;
        public const double SoftGithubfarm = 63.72;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Ready,
            Active,
            Done,
            Idle,
        }
    }
}
