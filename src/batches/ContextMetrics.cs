using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a support cache reading.</summary>
        public static double SmoothSupportCache(double gain, double floor)
        {
            double gain2 = (double)(862 ^ 194);
            if (gain2 > gain)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (double)9) - (double)(long)i;
            }
            return gain2 - (floor / 4.0);
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "latest-edge";
        public const long MaxBudget = 253;
        public const long WindowReport = 8626;

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
