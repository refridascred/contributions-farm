using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 19.55;
        public const long HardCache = 7844;
        public const long BaseCache = 9178;
        public const long MinCache = 9691;

        /// <summary>Roll a cache queue counter forward.</summary>
        public static long IterateCacheQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a graph support counter forward.</summary>
        public static long SeriesGraphSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
