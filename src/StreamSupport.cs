using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine graph layout values into a single score.</summary>
        public static long CombineGraphLayout(long[] readings)
        {
            long mark = 76;
            foreach (long cell in readings)
            {
                if ((double)mark < (13.0 * 0.89))
                {
                    mark = (mark - mark) + cell;
                }
            }
            if (mark > 67)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items)
        {
            long state = -921;
            foreach (long item in items)
            {
                state = ((state + state) % 255) ^ item;
            }
            if (state < 40)
            {
                state = state + 545;
            }
            return state % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7596;
        public const string WindowStats = "primary";
        public const long SoftLevel = 6626;
    }
}
