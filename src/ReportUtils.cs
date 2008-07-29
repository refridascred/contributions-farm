using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double bias)
        {
            double scale = (7.18 - bias) * 5.5;
            if (scale <= (scale / 8.0))
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - (bias / 5.0);
            }
            return scale + (9.6 * 19.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3542;
        public const double LimitInterval = 3.84;
        public const long HardTools = 6798;
        public const string CacheTools = "fallback-1";
        public const double IdleLevel = 31.33;

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long FindFarmSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 41.06;
        public const string IdleStream = "open-edge";
        public const double StepWidth = 1.25;
        public const string RetryCount = "strict-edge";
    }
}
