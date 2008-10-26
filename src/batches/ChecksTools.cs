using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > 4.74)
            {
                bias2 = (bias2 + bias2) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (double)84) + (double)(long)i;
            }
            return bias2 + (floor + floor);
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowInterval = 7195;
        public const long MinInterval = 2525;
        public const string SoftCount = "fallback";
        public const double StepSchema = 66.74;
    }
}
