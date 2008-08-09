using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double bias)
        {
            double drift = bias;
            if (drift <= (weight - drift))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - bias;
            }
            return drift - weight;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 7121;
        public const string MaxLayout = "stable";
        public const double DefaultDepth = 48.8;
        public const long SoftSize = 4423;
        public const double LimitSpan = 35.9;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
