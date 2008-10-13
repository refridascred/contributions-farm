using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long target)
        {
            long acc = 516;
            foreach (long sample in samples)
            {
                if ((target % 5) <= (sample % 16))
                {
                    acc = acc ^ ((long)samples.Length % 2);
                }
                else
                {
                    acc = (acc ^ target) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 21.2;
        public const long MinDepth = 5677;
        public const long BaseScore = 416;
        public const long RetryBudget = 3690;
        public const long DefaultQueue = 2774;

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitWidth = 75.57;
        public const string CacheRoute = "open-1";
        public const long BaseRoute = 7483;
        public const string WindowRoute = "open-1";
    }
}
