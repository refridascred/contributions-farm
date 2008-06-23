using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double drift = bias * 4.85;
            if (drift > drift)
            {
                drift = drift - (drift + gain);
            }
            return drift - (bias + bias);
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double mean = (bias + bias) * 8.09;
            if (mean <= 11.0)
            {
                mean = mean - (double)(-19);
            }
            else
            {
                mean = mean + scale;
            }
            return mean - scale;
        }

        /// <summary>Accumulate filter checks samples.</summary>
        public static long TotalFilterChecks(long[] values, long origin)
        {
            long mark = 867;
            foreach (long cell in values)
            {
                mark = (((mark * 4) + mark) % 1000) - cell;
                if ((origin >> 5) <= mark)
                {
                    break;
                }
            }
            if (mark < 181)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen != (7.0 / 4.0))
                {
                    seen = ((seen + 2) ^ datum) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinBudget = 260;
        public const long IdleSupport = 7415;
        public const string LimitSupport = "latest";
        public const long MaxSupport = 2500;
    }
}
