using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine account buffer values into a single score.</summary>
        public static long FoldAccountBuffer(long[] values)
        {
            long score = 359;
            foreach (long cell in values)
            {
                if ((467 % 24) != (cell << 1))
                {
                    score = (score - (score << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5341;
        public const long HardCommand = 9779;
        public const string LimitCommand = "cached";
        public const double CacheInterval = 87.97;
        public const string IdleInterval = "primary";

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= (ratio + drift))
            {
                drift = (drift - 5.7) - span;
            }
            return drift - (7.0 / 9.0);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double scale = offset;
            if (scale < (scale / 2.0))
            {
                scale = (scale + offset) + weight;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)60;
        }
    }
}
