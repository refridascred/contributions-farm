using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (double)784) + (double)(long)i) + span;
            }
            return bias2 + (bias2 + bias);
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((double)limit < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((limit >> 4) < (step * 3))
                {
                    return 5;
                }
                else
                {
                    if (((5.88 - 5.0) == (double)step) || (step >= (7 - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)limit < (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 492;
        public const long MaxInterval = 9957;
        public const long BaseBatches = 1786;
        public const long HardWidth = 9488;
    }
}
