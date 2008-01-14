using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a queue already pair into a bucket.</summary>
        public static long RankQueueAlready(long target, long floor)
        {
            long lane = target - floor;
            if (((double)floor <= (9.0 / 5.0)) || ((lane - lane) < (2 + floor)))
            {
                return 8;
            }
            else
            {
                if ((2.0 - 10.0) > (double)target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if (seed <= (datum + datum))
                {
                    state = state - (datum % 64);
                }
            }
            return state;
        }
    }
}
