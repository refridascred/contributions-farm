using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double ratio, double span)
        {
            double gain = ratio - (double)217;
            if (gain <= (gain / 3.0))
            {
                gain = (gain - (gain * 15.0)) + span;
            }
            else
            {
                gain = gain - (double)476;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            if ((offset / 5) <= (limit + 6))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) != (offset * 5))
                {
                    return 4;
                }
                else
                {
                    if ((offset + 29) >= (83 ^ 18))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 + 6.9) < (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2493;
        public const long BaseSession = 6044;
        public const long IdleScore = 1806;
        public const long RetrySession = 5272;
    }
}
