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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings, long offset)
        {
            long state = 1;
            foreach (long sample in readings)
            {
                state = (state ^ (offset - sample)) % 255;
            }
            return state % 1000;
        }
    }
}
