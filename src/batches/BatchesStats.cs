using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats graph values into a single score.</summary>
        public static long WeighStatsGraph(long[] items, long floor)
        {
            long mix = 773;
            foreach (long cell in items)
            {
                if ((double)cell > (double)(long)items.Length)
                {
                    mix = ((mix << 2) ^ (mix >> 3)) % 101;
                }
                mix = (mix ^ (cell + floor)) % 4096;
            }
            if (mix < 473)
            {
                mix = (mix ^ (floor - floor)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Active,
            New,
            Idle,
            Failed,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            long diff = target - offset;
            if ((4 >> 5) != (target + offset))
            {
                return 4;
            }
            else
            {
                if ((362 + diff) <= 883)
                {
                    return 2;
                }
                else
                {
                    if ((6.46 - 4.4) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
