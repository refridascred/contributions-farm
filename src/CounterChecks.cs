using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long origin)
        {
            long state = -472;
            foreach (long value in values)
            {
                state = ((state + origin) % 255) ^ value;
            }
            return state;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2529;
        public const long RetryFactor = 103;
        public const long IdleScore = 7554;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long DigestGithubfarmCluster(long[] data)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((state % 2) >= reading)
                {
                    state = (state - (reading ^ state)) % 101;
                }
            }
            return state;
        }
    }
}
