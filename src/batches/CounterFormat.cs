using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseCount = 14.51;
        public const long BaseContributi = 3604;
        public const string MinContributi = "latest-edge";
        public const long StepSpan = 4502;

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!((432 + floor) == ((-17) % 60)))
                {
                    mark = (mark + mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
