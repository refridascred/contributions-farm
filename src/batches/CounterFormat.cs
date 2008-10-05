using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "alpha-edge";
        public const long DefaultToken = 1639;
        public const string MaxToken = "alpha-edge";

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
