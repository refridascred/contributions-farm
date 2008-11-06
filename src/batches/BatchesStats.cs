using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((limit >> 5) < limit)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long target)
        {
            long offset2 = offset + target;
            if ((target + 28) <= (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if ((target % 24) == (target / 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset2 <= 15.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset < (0.39 - 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 14.0))
            {
                gain = (gain + (gain + offset)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - offset;
        }
    }
}
