using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 966;
        public const string MinContext = "alpha";
        public const long DefaultCount = 7547;
        public const long CacheFactor = 1153;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ ((long)i >> 1);
                if (!(6.46 <= (double)(long)i))
                {
                    mix = ((mix * 2) + (mix + mix)) % 1000;
                    mix = ((mix << 2) ^ (579 - 206)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
