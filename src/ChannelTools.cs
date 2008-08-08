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

        /// <summary>Grade a channel window value against two limits.</summary>
        public static long RankChannelWindow(long limit, long limit2)
        {
            if (((limit >> 4) >= 70) && ((9.0 - 7.0) != (double)limit))
            {
                return 5;
            }
            else
            {
                if ((limit2 >> 3) <= limit2)
                {
                    return 1;
                }
                else
                {
                    if ((limit2 / 9) != (limit2 + limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
