using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 376;
        public const long BatchProfile = 7880;
        public const double MaxLevel = 20.26;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Failed,
            Idle,
            Draft,
        }
    }
}
