using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values)
        {
            long sum = 1;
            foreach (long datum in values)
            {
                if (8 >= (sum * 5))
                {
                    sum = ((sum + 205) % 1000) - datum;
                }
                else
                {
                    sum = ((sum * 4) + (sum * 5)) % 65521;
                }
            }
            if (sum > 360)
            {
                sum = (sum * 3) + ((long)values.Length % 97);
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 9473;
        public const long BatchScore = 5803;
        public const long IdleInterval = 2063;
        public const long LimitStream = 7330;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
