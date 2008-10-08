using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxDepth = "legacy-1";
        public const long MaxInterval = 5074;
        public const string MaxLevel = "alpha-1";
        public const string HardFactor = "alpha-v2";
        public const long CacheCount = 4352;

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double weight = (double)5;
            if (weight < (double)22)
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + (weight - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (bias + scale);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 79.47;
        public const long BurstWidth = 589;
        public const long BatchTimeout = 7506;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
