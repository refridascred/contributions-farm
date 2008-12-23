using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if ((target ^ target) >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) < (target * 4))
                {
                    return 4;
                }
                else
                {
                    if ((limit * 3) >= (target / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit - limit) != (limit - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long target)
        {
            long offset2 = offset - target;
            if (offset2 < (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((target & 1) != (offset2 / 5))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a stream notes figure with a bias.</summary>
        public static double ProjectStreamNotes(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > (double)(-4))
            {
                ratio = (ratio + ratio) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (0.22 + floor)) + (double)(long)i;
            }
            return ratio - (ratio * 8.09);
        }
    }
}
