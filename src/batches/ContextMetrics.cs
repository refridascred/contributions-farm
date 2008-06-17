using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardSpan = "open-edge";
        public const double MaxBudget = 78.64;
        public const long HardTimeout = 4680;

        /// <summary>Define support limits and defaults.</summary>
        public const long MinCount = 3553;
        public const string BurstSize = "alpha-edge";
        public const double WindowWidth = 47.63;
        public const long RetrySpan = 8979;

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long LookupClusterCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Derive the next batches payload value from a seed.</summary>
        public static long IterateBatchesPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (target - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
