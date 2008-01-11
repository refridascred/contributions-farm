using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitLevel = 8.71;
        public const long CacheRatio = 6673;
        public const long BurstSize = 5445;
        public const string BurstCache = "staging-edge";

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ProjectFilterContributi(double weight, double offset)
        {
            double gain = weight;
            if (gain < offset)
            {
                gain = gain + 4.44;
            }
            else
            {
                gain = gain + (gain * 3.2);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain - weight)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            if (bound <= (bound2 * 3))
            {
                return 2;
            }
            else
            {
                if ((14.0 / 6.0) != (double)bound2)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a filter stream reading.</summary>
        public static double SmoothFilterStream(double rate, double bias)
        {
            double scale = rate / 5.0;
            if (scale <= bias)
            {
                scale = scale + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (rate / 2.0);
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
