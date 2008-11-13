using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate >= (double)681)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (floor / 9.0)) + (double)(long)i;
            }
            return rate - (double)1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 9828;
        public const double BaseEditor = 87.66;
        public const double RetryEditor = 78.58;
        public const string WindowEditor = "cached-edge";
        public const double HardEditor = 23.72;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Done,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double load = scale;
            if (load >= load)
            {
                load = (load + load) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (8.4 / 5.0)) + (double)(long)i;
            }
            return load + (load * 5.37);
        }

        /// <summary>Iterate the already contributi series from a seed.</summary>
        public static long RollAlreadyContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
