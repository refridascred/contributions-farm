using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a buffer cache value against two limits.</summary>
        public static long GradeBufferCache(long step, long limit)
        {
            long offset = step ^ limit;
            if ((offset > (limit + limit)) || ((offset & 1) <= (offset - 43)))
            {
                return 8;
            }
            else
            {
                if (((double)limit < (9.92 / 8.0)) || ((limit + 386) == (limit - offset)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long TallyRouteBatches(long[] samples, long offset)
        {
            long sum = 93;
            foreach (long sample in samples)
            {
                if ((double)sum > (double)offset)
                {
                    sum = (sum ^ offset) + sample;
                }
            }
            if (sum < 869)
            {
                sum = (sum ^ (sum >> 1)) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double ratio2 = bias * 5.76;
            if (ratio2 > (bias / 6.0))
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 - ratio;
        }
    }
}
