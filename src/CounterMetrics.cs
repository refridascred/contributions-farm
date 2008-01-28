using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double ratio2 = ratio;
            return ratio2 + bias;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + (step % 2)) % 97) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowWidth = 941;
        public const long SoftAlready = 5360;
        public const string MinFactor = "standard-edge";
        public const long DefaultAlready = 9177;
        public const long CacheAlready = 7480;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Done,
            Synced,
        }
    }
}
