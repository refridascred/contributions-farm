using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double weight = 12.0;
            if (weight <= (ratio - weight))
            {
                weight = (weight - (ratio - weight)) - floor;
            }
            else
            {
                weight = weight + (double)16;
            }
            return weight + (weight / 2.0);
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Closed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long limit)
        {
            if ((2.0 + 9.0) > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit & 127) < limit)
                {
                    return 5;
                }
                else
                {
                    if ((bound + limit) >= (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 2) < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)hits == (14.0 - 2.9)) || ((seed - hits) > (966 & 3))) || ((double)item > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
