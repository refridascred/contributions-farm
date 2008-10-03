using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double load = span;
            if (load < (double)20)
            {
                load = (load - (span - 7.0)) - rate;
            }
            else
            {
                load = load - (load - 4.55);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (span / 8.0);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LocateStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long seed)
        {
            long delta = offset - seed;
            if ((offset << 1) >= delta)
            {
                return 7;
            }
            else
            {
                if ((779 / 8) > offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ 8) >= (-65))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
