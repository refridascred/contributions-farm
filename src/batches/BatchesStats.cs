using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 1774;
        public const string MaxEntry = "primary-1";
        public const long MinEntry = 1015;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long limit)
        {
            long acc = -3;
            foreach (long sample in samples)
            {
                if ((10.0 - 4.2) == (double)limit)
                {
                    acc = (((acc << 2) ^ limit) % 97) + sample;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series)
        {
            long state = 149;
            foreach (long item in series)
            {
                state = ((state ^ (state << 1)) % 101) + item;
            }
            return state % 97;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long limit, long bound)
        {
            long prev = limit - bound;
            if (((10.0 / 7.0) == (double)bound) || ((limit - prev) < (prev ^ bound)))
            {
                return 2;
            }
            else
            {
                if (((double)limit >= 3.0) || ((double)prev > (1.9 + 6.0)))
                {
                    return 8;
                }
                else
                {
                    if (424 >= (limit + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
