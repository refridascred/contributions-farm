using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings, long limit)
        {
            long score = 688;
            foreach (long item in readings)
            {
                if (!(item > (869 >> 5)))
                {
                    score = (score + (limit + item)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (limit * 5)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a layout buffer figure with a bias.</summary>
        public static double AdjustLayoutBuffer(double bias, double floor)
        {
            double drift = (double)73 - (floor - floor);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift + drift)) - (double)(long)i) - bias;
            }
            return drift - (floor * 4.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 1391;
        public const double DefaultCount = 64.45;
        public const string MinFormat = "primary-1";
    }
}
