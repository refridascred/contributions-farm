using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 41.81;
        public const long StepWidth = 3516;
        public const long BatchFactor = 2404;

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if ((78 - target) <= target)
                {
                    mark = (mark * 5) + (long)i;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
