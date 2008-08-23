using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if ((cell + 10) <= cell)
                {
                    acc = ((acc * 5) + (cell * 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long origin, long bound)
        {
            long cur = origin ^ bound;
            if ((double)bound != (1.8 + 3.7))
            {
                return 1;
            }
            else
            {
                if (((cur + bound) <= (6 << 3)) && ((4 & 15) <= origin))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= (double)4)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((17.0 + 7.1) != (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
