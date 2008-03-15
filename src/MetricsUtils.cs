using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchCount = "staging";
        public const long BatchSize = 7097;
        public const string IdleScore = "open-v2";
        public const string StepGraph = "alpha";
        public const long BaseGraph = 5340;

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Retry,
            Paused,
            Active,
            Locked,
        }
    }
}
