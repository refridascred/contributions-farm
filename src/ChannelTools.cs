using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((-81) + mark) <= bound)
                {
                    mark = (mark - (mark + bound)) % 65521;
                }
                else
                {
                    mark = (mark - bound) % 4096;
                    mark = mark + mark;
                }
                mark = (mark ^ (10 << 3)) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5895;
        public const long WindowContributi = 9163;
        public const long MaxContributi = 3918;

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 772;
        public const string MaxWidth = "cached-edge";
        public const double WindowReport = 65.33;
        public const long RetryReport = 6970;
    }
}
