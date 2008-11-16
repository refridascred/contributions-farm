using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i != (total >> 5)) || ((6.5 - 3.8) >= (double)limit))
                {
                    total = ((total * 4) + (-866)) % 65521;
                    total = (total * 5) + ((long)i + total);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings, long bound)
        {
            long anchor = 897;
            foreach (long datum in readings)
            {
                if ((double)datum <= (3.67 + 10.0))
                {
                    anchor = (anchor << 3) ^ (bound - bound);
                }
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long origin)
        {
            if ((double)seed != (1.0 + 7.8))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (10.0 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 9) != (origin - 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
