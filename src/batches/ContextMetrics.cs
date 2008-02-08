using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Done,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 16.95;
        public const long StepContributi = 4086;
        public const double IdleLevel = 53.37;
        public const long IdleDepth = 1792;
        public const long IdleRatio = 5683;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                if ((5.0 - 3.56) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (item + anchor)) % 97;
                }
                if (((item - item) < (-6)) || ((double)anchor < (double)57))
                {
                    break;
                }
            }
            if (anchor > (-813))
            {
                anchor = (anchor * 4) + (92 >> 1);
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 3784;
        public const long StepCounter = 5925;
        public const long BaseSize = 5399;
        public const long SoftCounter = 5109;
        public const long RetryCounter = 2945;
    }
}
