using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((37 + (long)i) < ((long)i + offset)) || ((8.5 * 7.0) > (double)(long)i))
                {
                    acc = (acc * 3) + (444 + (-681));
                }
                else
                {
                    acc = (acc ^ (acc % 7)) % 101;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc - (acc & 127)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 61.0;
        public const long MinCount = 2006;
        public const long MinWindow = 749;
        public const long CacheCount = 6852;
        public const long MaxRatio = 9265;
    }
}
