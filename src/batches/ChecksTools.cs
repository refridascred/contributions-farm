using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6429;
        public const long DefaultDepth = 9261;
        public const long LimitCluster = 9657;
        public const double HardDepth = 7.39;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((offset * 4) == (offset * 5)) || ((mark * 2) <= (mark * 5)))
                {
                    mark = (mark << 3) ^ (18 ^ offset);
                }
                else
                {
                    mark = ((mark * 3) + ((-109) & 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double span)
        {
            double rate2 = (double)396 / 2.0;
            for (int i = 0; i < 8; i++)
            {
                rate2 = (((rate2 + (rate2 / 8.0)) + (double)(long)i) + rate) - span;
            }
            return rate2 + rate2;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
