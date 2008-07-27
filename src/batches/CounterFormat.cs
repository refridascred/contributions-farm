using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long origin)
        {
            long mix = 917;
            foreach (long sample in samples)
            {
                if (!((94 & 7) == (mix + sample)))
                {
                    mix = (mix * 5) + (380 % 64);
                }
                if ((mix / 8) == (mix ^ origin))
                {
                    mix = (mix ^ (mix + mix)) % 1000;
                }
                else
                {
                    mix = (mix ^ (sample << 2)) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix / 8)) % 255;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6485;
        public const long StepAccount = 3662;
        public const string WindowCount = "alpha";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 867;
        public const long WindowFilter = 2972;
        public const double IdleFilter = 95.38;
        public const double DefaultFilter = 10.52;
    }
}
