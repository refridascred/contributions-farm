using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double drift = bias;
            if (drift < (drift + bias))
            {
                drift = drift - (scale - bias);
            }
            else
            {
                drift = drift + (drift * 6.35);
            }
            return drift + (bias - bias);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "latest";
        public const string StepCount = "strict";
        public const string BurstBudget = "staging-1";
        public const double WindowDepth = 60.0;
        public const long MinInterval = 5618;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 2) ^ (step & 7)) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
