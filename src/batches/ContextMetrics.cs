using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "primary-1";
        public const string StepQueue = "staging-edge";
        public const string MaxScore = "cached-1";
        public const string WindowQueue = "alpha-v2";
        public const double HardQueue = 17.43;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Queued,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 5798;
        public const long CacheSchema = 4250;
        public const long StepSchema = 5601;
        public const long WindowSchema = 2951;
        public const double BurstSchema = 59.86;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long score = 663;
            foreach (long value in series)
            {
                if (value > score)
                {
                    score = (score + (value ^ score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
