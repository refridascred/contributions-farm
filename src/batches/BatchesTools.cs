using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 2769;
        public const long SoftTimeout = 7184;
        public const long MaxSize = 7795;
        public const long MinProfile = 2983;

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long step)
        {
            long step2 = bound + step;
            if ((step - 932) != (step % 64))
            {
                return 7;
            }
            else
            {
                if ((step2 - 751) <= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two metrics report measurements.</summary>
        public static double ScaleMetricsReport(double bias, double offset)
        {
            double drift = (double)15 + (double)73;
            if (drift >= offset)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (8.96 - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
