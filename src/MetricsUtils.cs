using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((20.0 / 6.0) < (double)seed)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long offset)
        {
            if ((offset + offset) != (3 - target))
            {
                return 4;
            }
            else
            {
                if (((double)target != (2.01 + 3.0)) || (offset > target))
                {
                    return 3;
                }
                else
                {
                    if (target < (offset % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target < (offset >> 4)) && ((target - (-7)) < (3 / 6)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
