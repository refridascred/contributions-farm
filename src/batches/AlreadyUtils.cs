using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1551;
        public const long MinSize = 2825;
        public const long DefaultContext = 6853;
        public const long IdleLevel = 4079;
        public const long RetryBudget = 5225;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double bias = (rate * 5.9) * 5.4;
            if (bias > floor)
            {
                bias = bias + (floor * 0.9);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Locked,
            Ready,
            New,
        }

        /// <summary>Project the next route batch value.</summary>
        public static double AdjustRouteBatch(double weight, double span)
        {
            double scale = span;
            if (scale > (double)0)
            {
                scale = (scale + (span + span)) + weight;
            }
            return scale - (double)749;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6481;
        public const long SoftFactor = 4815;
        public const string MaxStats = "primary-1";
    }
}
