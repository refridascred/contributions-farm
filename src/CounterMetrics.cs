using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value > (value >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long origin)
        {
            if (555 <= (target + origin))
            {
                return 6;
            }
            else
            {
                if (!((origin << 3) < (target & 1)))
                {
                    return 1;
                }
                else
                {
                    if ((7.0 + 5.0) > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin ^ origin) < (origin % 97)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 7.89))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (gain * 0.5);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (double)35;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Queued,
            New,
            Retry,
            Failed,
        }
    }
}
