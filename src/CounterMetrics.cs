using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel cache readings.</summary>
        public static long TotalChannelCache(long[] items)
        {
            long state = 569;
            foreach (long cell in items)
            {
                if (cell < (0 + cell))
                {
                    long count = cell * 5;
                    state = (state + (count - count)) % 255;
                }
                state = (state << 2) ^ state;
            }
            if (state > 781)
            {
                state = (state - (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 376;
        public const long BatchProfile = 7880;
        public const double MaxLevel = 20.26;

        /// <summary>Count queue profile pairs that satisfy a relation.</summary>
        public static long PairQueueProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
