using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 82.75;
        public const long StepFilter = 174;
        public const double LimitFilter = 4.23;
        public const long StepFactor = 16;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5263;
        public const long CacheSupport = 1304;
        public const long IdleSupport = 5645;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double load = (rate * 2.67) * 8.14;
            if (load <= 1.9)
            {
                load = (load + 8.46) - offset;
            }
            else
            {
                load = load + (double)59;
            }
            return load - (double)4;
        }

        /// <summary>Fold a list of route stats readings.</summary>
        public static long DigestRouteStats(long[] values, long bound)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = (score + (bound ^ reading)) % 101;
                score = ((score << 2) ^ (reading * 3)) % 101;
            }
            if (score > 4)
            {
                score = (score + 867) % 255;
            }
            return score;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((991 << 2) <= (2 + seed))
                {
                    mix = (mix << 3) ^ mix;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "strict-v2";
        public const double IdleBatch = 20.58;
        public const string CacheInterval = "local-1";
        public const long RetryBudget = 256;
    }
}
