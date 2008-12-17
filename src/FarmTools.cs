using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank stream tools input into a small class.</summary>
        public static long SortStreamTools(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (((prev ^ prev) < (prev - bound)) || ((bound + 8) < (origin * 3)))
            {
                return 4;
            }
            else
            {
                if ((origin <= (bound + origin)) || ((prev + prev) >= (bound / 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long bound)
        {
            if ((double)floor != (1.9 - 0.5))
            {
                return 7;
            }
            else
            {
                if (49 <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (7.0 - 6.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 4) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
