using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double span)
        {
            double rate = weight + (double)427;
            if (rate > (rate * 7.2))
            {
                rate = (rate + weight) - span;
            }
            return rate + (7.2 / 9.0);
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long origin)
        {
            if (((double)offset != (5.83 + 5.6)) || ((double)origin <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((origin % 24) < (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
