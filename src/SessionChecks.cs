using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank graph schema input into a small class.</summary>
        public static long ClassifyGraphSchema(long limit, long origin)
        {
            long gap = limit + origin;
            if ((40 / 3) >= origin)
            {
                return 7;
            }
            else
            {
                if ((827 >= (gap % 12)) || (gap > (origin % 8)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 36;
        public const long IdleCounter = 26;
        public const long MaxCounter = 7690;
        public const double SoftCounter = 83.42;
        public const long MinScore = 7737;

        /// <summary>Project the next already queue value.</summary>
        public static double SmoothAlreadyQueue(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < span)
            {
                rate2 = rate2 - (double)67;
            }
            else
            {
                rate2 = rate2 + (span - 19.0);
            }
            return rate2 - span;
        }
    }
}
