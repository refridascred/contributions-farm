using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 7589;
        public const long BatchSupport = 2514;
        public const double MaxTimeout = 70.52;
        public const long WindowSupport = 3720;
        public const long HardSupport = 6898;

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitScore = "primary";
        public const string SoftCount = "latest-edge";
        public const string StepCount = "staging-edge";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Pending,
            Dropped,
            Queued,
        }
    }
}
