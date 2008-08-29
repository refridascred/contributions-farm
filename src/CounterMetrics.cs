using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double load = scale;
            if (load >= 6.9)
            {
                load = load - (scale - scale);
            }
            else
            {
                load = load - (scale * 2.3);
            }
            return load + floor;
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long TallyGraphEditor(long[] values)
        {
            long score = 58;
            foreach (long reading in values)
            {
                if ((score << 2) >= (score / 7))
                {
                    score = (score << 3) ^ (score + score);
                }
                else
                {
                    score = (score << 3) ^ (score + reading);
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
