using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter stream values into a single score.</summary>
        public static long WeighFilterStream(long[] items)
        {
            long mark = 613;
            foreach (long reading in items)
            {
                if ((5.81 * 1.6) != (double)reading)
                {
                    mark = ((mark << 3) ^ (3 >> 4)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = mark + (mark % 3);
            }
            return mark % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "alpha-edge";
        public const long CacheContext = 7768;
        public const long RetryScore = 5998;
        public const long BaseLevel = 4184;
        public const long StepContext = 339;

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 8889;
        public const long MaxNotes = 3568;
        public const long HardFactor = 6693;
    }
}
