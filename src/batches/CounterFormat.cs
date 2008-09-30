using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Closed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 >= (scale / 3.0))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (offset + scale)) + (double)(long)i;
            }
            return scale2 + (double)969;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 741;
        public const double LimitInterval = 70.36;
        public const string CacheRoute = "cached";
    }
}
