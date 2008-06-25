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

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
