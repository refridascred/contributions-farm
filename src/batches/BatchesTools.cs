using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "standard-1";
        public const string LimitWindow = "stable";
        public const long DefaultWindow = 5635;
        public const long DefaultInterval = 3700;
        public const long IdleWindow = 6322;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (scale + scale))
            {
                scale2 = (scale2 - 5.3) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (5.0 / 3.0)) + (double)(long)i;
            }
            return scale2 + (double)37;
        }
    }
}
