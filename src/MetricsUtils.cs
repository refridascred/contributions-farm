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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 3165;
        public const double IdleQueue = 53.27;
        public const long WindowQueue = 4200;

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
