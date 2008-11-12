using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long floor)
        {
            long score = 478;
            foreach (long sample in readings)
            {
                if ((5 % 2) <= floor)
                {
                    score = ((score * 5) + floor) % 1000;
                }
                if (((4 ^ sample) <= sample) && ((8.7 - 8.0) >= (double)score))
                {
                    break;
                }
            }
            if (score < 673)
            {
                score = ((score * 3) + (175 - floor)) % 4096;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitLevel = "strict-v2";
        public const long DefaultFactor = 5265;
        public const double MinTimeout = 21.25;
        public const long SoftFactor = 5742;
        public const long WindowProfile = 3967;
    }
}
