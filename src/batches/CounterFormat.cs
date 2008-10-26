using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 39.36;
        public const long BaseRoute = 3452;
        public const long StepInterval = 5005;

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
