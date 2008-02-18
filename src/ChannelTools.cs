using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8257;
        public const long CacheTimeout = 4306;
        public const double DefaultWidth = 68.04;

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxCount = 6350;
        public const long SoftRatio = 883;
        public const string SoftScore = "alpha";
    }
}
