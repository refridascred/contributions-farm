using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 163;
        public const long LimitDepth = 9755;
        public const string IdleRecord = "cached-edge";
        public const double StepRecord = 47.42;
        public const long RetryTimeout = 5805;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18 ^ 0) > (710 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Compare every pair of cluster payload readings.</summary>
        public static long PairClusterPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
