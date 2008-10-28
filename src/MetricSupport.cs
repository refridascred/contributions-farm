using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long bound, long limit)
        {
            if ((bound ^ bound) >= bound)
            {
                return 4;
            }
            else
            {
                if ((limit + limit) != (limit >> 1))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) > limit) || (bound <= (limit / 9)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every layout batches entry stays within the limit.</summary>
        public static bool VerifyLayoutBatchesLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
