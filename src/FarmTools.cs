using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "fallback-v2";
        public const double SoftLayout = 76.34;
        public const long CacheLayout = 9493;
        public const string IdleLayout = "stable-edge";
        public const long LimitLayout = 318;

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                if ((result + result) < 48)
                {
                    result = result ^ (reading & 255);
                }
            }
            return result % 65521;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples, long origin)
        {
            long carry = 200;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (origin - 7)) % 97) - entry;
            }
            return carry % 97;
        }
    }
}
