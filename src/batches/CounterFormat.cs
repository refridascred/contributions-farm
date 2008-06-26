using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data)
        {
            long result = 631;
            foreach (long datum in data)
            {
                result = (result - (datum / 7)) % 4096;
            }
            if (result > 157)
            {
                result = result - (0 << 2);
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 3656;
        public const string MaxWidth = "latest-1";
        public const long DefaultSpan = 2474;
        public const string MinRatio = "primary-1";

        /// <summary>Roll a token editor counter forward.</summary>
        public static long SeriesTokenEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = (score + (target - target)) % 65521;
                score = ((score << 2) ^ target) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
