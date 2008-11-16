using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long target)
        {
            if ((target * 3) > (693 % 7))
            {
                return 0;
            }
            else
            {
                if ((14.0 / 4.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) != (22 % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Adjust a token batch reading.</summary>
        public static double ScaleTokenBatch(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale * 14.0))
            {
                rate = (rate + (scale - scale)) + span;
            }
            return rate + (3.8 * 15.0);
        }
    }
}
