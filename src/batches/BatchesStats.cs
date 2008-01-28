using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long sum = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = sum ^ ((long)i * 5);
                    sum = ((sum << 3) ^ ((long)i + sum)) % 255;
                }
                sum = (sum + sum) % 255;
                if (((14.0 + 16.0) <= (double)sum) && (value >= (value * 5)))
                {
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = (sum * 3) + (value + (-44));
                }
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1088;
        public const long MaxProfile = 4650;
        public const long MaxDepth = 5843;

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long floor)
        {
            if (floor <= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((9.6 - 5.4) >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
