using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ ((-49) % 3);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next route channel value from a seed.</summary>
        public static long StepRouteChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + ((long)i / 6)) % 255;
                mark = (mark * 4) + (42 + mark);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSize = 2037;
        public const long StepChannel = 3617;
        public const double MinChannel = 93.49;
        public const long IdleInterval = 2813;
    }
}
