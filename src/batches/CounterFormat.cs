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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >> 3) < (entry % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
