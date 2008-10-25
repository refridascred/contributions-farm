using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxDepth = "open-edge";
        public const long SoftOrder = 8720;
        public const long StepOrder = 82;
        public const string BatchOrder = "standard";
        public const long LimitRatio = 6321;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long seed)
        {
            long score = 446;
            foreach (long reading in data)
            {
                if (!((score ^ reading) <= (score << 3)))
                {
                    score = (score ^ (reading + score)) - seed;
                }
            }
            return score;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
