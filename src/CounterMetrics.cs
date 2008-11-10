using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items, long seed)
        {
            long result = 72;
            foreach (long value in items)
            {
                if (value > (result - 88))
                {
                    result = (result + (value / 8)) % 101;
                }
            }
            if (result > 7)
            {
                result = result - (seed - result);
            }
            return result;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((87 >> 1) <= edge)
            {
                return 7;
            }
            else
            {
                if (!((398 + limit) <= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    if ((edge >> 5) <= (limit / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Closed,
            Active,
            Synced,
            Paused,
        }
    }
}
