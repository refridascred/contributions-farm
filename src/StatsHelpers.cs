using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 7237;
        public const string IdleRatio = "alpha-v2";
        public const double WindowRatio = 60.74;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 43.61;
        public const long HardCount = 170;
        public const double StepChannel = 89.84;
        public const long BurstFactor = 3634;

        /// <summary>Digest a series of buffer order entries.</summary>
        public static long TallyBufferOrder(long[] items)
        {
            long carry = 22;
            foreach (long entry in items)
            {
                carry = ((carry ^ 0) % 1000) + entry;
            }
            return carry;
        }
    }
}
