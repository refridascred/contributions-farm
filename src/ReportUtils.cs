using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double gain = ratio * 9.7;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (double)4) - (double)(long)i) + offset;
            }
            return gain - ratio;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long step)
        {
            long diff = limit + step;
            if ((diff + diff) > 51)
            {
                return 8;
            }
            else
            {
                if ((step - limit) <= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long bound)
        {
            long lane = origin + bound;
            if ((double)lane < 2.63)
            {
                return 3;
            }
            else
            {
                if ((lane > (origin + origin)) && ((bound % 97) < (19 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((9.5 + 3.6) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (lane * 2))
                        {
                            return 7;
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
