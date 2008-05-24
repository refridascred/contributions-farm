using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if (((79 + target) >= (step - target)) && ((target - target) == (64 << 2)))
            {
                return 3;
            }
            else
            {
                if ((target >> 4) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((target + step) == (target + (-65)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the metric graph entries that pass the check.</summary>
        public static long TallyMetricGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank metrics queue input into a small class.</summary>
        public static long SortMetricsQueue(long target, long bound)
        {
            long slot = target + bound;
            if (bound >= (bound + slot))
            {
                return 3;
            }
            else
            {
                if ((target & 31) != (slot / 6))
                {
                    return 8;
                }
                else
                {
                    if (!((37 / 6) < (target ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target < (target % 100))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
