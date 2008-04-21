using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                if ((57 - datum) < 9)
                {
                    acc = (acc ^ (acc + datum)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
                if ((datum > (acc + datum)) || ((datum & 1) > datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of queue stream readings.</summary>
        public static long CompareQueueStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ (state + (long)i);
                state = (state - ((-7) % 10)) % 4096;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 90.96;
        public const double StepInterval = 90.65;
        public const double BaseTools = 98.15;
    }
}
