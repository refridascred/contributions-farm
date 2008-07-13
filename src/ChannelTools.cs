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

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((bound * 4) >= (limit << 1))
            {
                return 3;
            }
            else
            {
                if ((8 + limit) < (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (((limit >> 3) < (4 - 72)) && ((double)bound <= (19.0 * 2.51)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 5777;
        public const string MaxCommand = "local-v2";
        public const long BaseSize = 5173;
        public const long BatchCommand = 8757;
        public const string WindowCommand = "alpha-1";
    }
}
