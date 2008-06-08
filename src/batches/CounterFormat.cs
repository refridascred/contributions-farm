using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardFactor = 9451;
        public const long RetryNotes = 3601;
        public const long DefaultNotes = 8074;

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4406;
        public const long MaxLayout = 5146;
        public const long MaxFactor = 5758;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = (result * 3) + ((long)i ^ (long)i);
                if ((double)(long)i <= 2.7)
                {
                    result = result - (987 + origin);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
