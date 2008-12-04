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

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark * 5) + (mark * 5)) % 1000) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
