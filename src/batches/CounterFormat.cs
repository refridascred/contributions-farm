using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every channel queue entry stays within the limit.</summary>
        public static bool ValidateChannelQueueLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a metric command pair into a bucket.</summary>
        public static long BucketMetricCommand(long limit, long step)
        {
            long diff = limit + step;
            if ((7.1 * 9.0) < (double)step)
            {
                return 5;
            }
            else
            {
                if ((diff + step) < limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit / 2) < (step ^ 8)) || ((step & 127) > (limit - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step < 18) && ((diff << 1) < (limit & 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
