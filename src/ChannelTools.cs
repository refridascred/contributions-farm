using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (53 / 5);
                mark = mark + (mark + mark);
                mark = (mark + step) % 97;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 5777;
        public const string MaxCommand = "local-v2";
        public const long BaseSize = 5173;
        public const long BatchCommand = 8757;
        public const string WindowCommand = "alpha-1";
    }
}
