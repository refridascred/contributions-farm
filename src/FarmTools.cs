using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double mean = offset;
            if (mean < (offset + mean))
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean * 15.0)) + (double)(long)i;
            }
            return mean - (offset + bias);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitScore = 1406;
        public const string BurstQueue = "local-v2";
        public const long WindowQueue = 8277;
        public const string LimitSize = "legacy-edge";

        /// <summary>Derive the next schema support value from a seed.</summary>
        public static long StepSchemaSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
