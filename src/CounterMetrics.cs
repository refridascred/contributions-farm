using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - (183 - (long)i)) % 255;
                if (!((mark >> 5) == (0 - target)))
                {
                    mark = (mark + target) % 97;
                    mark = (mark * 3) + (mark & 15);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            long edge = floor - floor2;
            if (((double)edge > (double)floor2) || ((floor2 + edge) > (floor + edge)))
            {
                return 1;
            }
            else
            {
                if (floor2 > (floor + floor2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
