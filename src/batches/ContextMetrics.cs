using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double rate = (double)58 * 0.8;
            if (rate > (double)1)
            {
                rate = (rate + (rate / 2.0)) + span;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (gain + 3.46);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = 755;
            foreach (long sample in values)
            {
                score = (score ^ sample) % 101;
            }
            return score;
        }

        /// <summary>Blend two schema editor measurements.</summary>
        public static double ScaleSchemaEditor(double scale, double floor)
        {
            double load = scale / 5.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)49) - (double)(long)i) - floor;
            }
            return load - scale;
        }

        /// <summary>Iterate the tools cluster series from a seed.</summary>
        public static long RollToolsCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (mark + (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "primary";
        public const string BurstCount = "cached-v2";
        public const double StepContext = 57.66;
        public const long CacheContext = 2548;
    }
}
