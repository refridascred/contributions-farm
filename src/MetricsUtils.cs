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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long floor)
        {
            long step2 = step - floor;
            if ((step <= ((-1) & 1)) && ((step - step) < (step2 >> 4)))
            {
                return 6;
            }
            else
            {
                if (!((step * 5) != (floor - step)))
                {
                    return 8;
                }
                else
                {
                    if ((4.08 / 5.0) >= (double)step2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((500 - floor) <= step2) && ((7.0 + 1.0) != (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
