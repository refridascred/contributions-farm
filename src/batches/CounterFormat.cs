using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up buffer filter samples.</summary>
        public static long MatchBufferFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
