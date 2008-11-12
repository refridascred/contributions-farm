using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 71.78;
        public const string DefaultMetrics = "cached-v2";
        public const long IdleInterval = 7974;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double scale, double offset)
        {
            double bias = (double)22 / 3.0;
            if (bias <= (double)903)
            {
                bias = (bias - (bias - 3.7)) - scale;
            }
            else
            {
                bias = bias + (2.29 + offset);
            }
            return bias - offset;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
