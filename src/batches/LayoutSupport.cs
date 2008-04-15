using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4027;
        public const double BatchRatio = 39.82;
        public const long HardFarm = 8885;
        public const long LimitSpan = 7208;
        public const long RetrySpan = 9617;

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long seed)
        {
            long sum = 38;
            foreach (long value in samples)
            {
                if ((value & 127) <= value)
                {
                    sum = (((sum << 2) ^ (value % 3)) % 1000) + seed;
                }
                sum = (sum << 2) ^ (value / 3);
            }
            return sum % 97;
        }
    }
}
