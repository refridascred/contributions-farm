using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 2708;
        public const long WindowTimeout = 7926;
        public const long BaseFactor = 4413;

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseTimeout = 5.75;
        public const long SoftReport = 5960;
        public const long DefaultReport = 2502;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 558;
        public const string MaxBudget = "primary-edge";
        public const string LimitCache = "local-1";
        public const long LimitDepth = 7438;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double gain = 1.0 + (bias / 6.0);
            if (gain < (span - span))
            {
                gain = gain - (8.27 / 3.0);
            }
            return gain + 3.48;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings)
        {
            long score = 3;
            foreach (long item in readings)
            {
                score = score - (item + score);
                if ((double)score <= (double)item)
                {
                    break;
                }
            }
            return score;
        }
    }
}
