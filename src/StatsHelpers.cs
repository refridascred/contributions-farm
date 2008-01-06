using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "latest-edge";
        public const long LimitTools = 3899;
        public const string BurstWidth = "fallback-v2";
        public const long StepTools = 2489;
        public const string BatchFactor = "legacy-v2";

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double span)
        {
            double bias = span / 4.0;
            if (bias <= (double)(-314))
            {
                bias = (bias - bias) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)78) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double rate = bias;
            if (rate <= (double)751)
            {
                rate = (rate + (double)82) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (rate * 20.0);
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
