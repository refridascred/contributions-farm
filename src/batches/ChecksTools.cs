using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a entry channel pair into a bucket.</summary>
        public static long BucketEntryChannel(long bound, long offset)
        {
            long gap = bound - offset;
            if (!((6.0 / 7.0) < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((2.81 - 6.0) < (double)gap)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a batch already reading.</summary>
        public static double AdjustBatchAlready(double weight, double span)
        {
            double mean = (weight + weight) - weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - span;
            }
            return mean + (weight - mean);
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long MeasureStreamTokenHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value << 2) <= (621 & 255))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}
