using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.39 * 2.51) < (double)value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
