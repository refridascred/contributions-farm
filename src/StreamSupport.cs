using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 8322;
        public const long BatchBudget = 2341;
        public const long LimitScore = 9689;
        public const double BaseChecks = 14.77;

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long bound)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((((sum << 2) ^ (sum + sum)) % 255) + sample) + bound;
            }
            return sum % 4096;
        }
    }
}
