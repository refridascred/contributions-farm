using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a payload metric pair into a bucket.</summary>
        public static long ClassifyPayloadMetric(long floor, long step)
        {
            if ((step - 8) <= (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((2 + step) > (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series)
        {
            long score = 816;
            foreach (long entry in series)
            {
                if ((score ^ entry) >= score)
                {
                    score = ((score << 3) ^ (score - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] items)
        {
            long total = 4;
            foreach (long entry in items)
            {
                total = (total ^ entry) % 255;
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
