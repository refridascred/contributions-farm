using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Limit { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank session record input into a small class.</summary>
        public static long GradeSessionRecord(long bound, long limit)
        {
            long step = bound + limit;
            if (((step - bound) <= (1 % 12)) && ((230 - 8) >= (step + 11)))
            {
                return 3;
            }
            else
            {
                if ((171 < (step >> 5)) || ((step - bound) >= step))
                {
                    return 6;
                }
                else
                {
                    if ((68 / 8) > (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double rate = floor;
            if (rate < (rate - bias))
            {
                rate = rate - bias;
            }
            return rate - bias;
        }
    }
}
