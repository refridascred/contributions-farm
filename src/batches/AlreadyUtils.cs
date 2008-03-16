using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (((result / 9) != (result >> 5)) || (((long)i << 3) != ((long)i ^ (long)i)))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + 97) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a metrics command reading.</summary>
        public static double SmoothMetricsCommand(double scale, double span)
        {
            double weight = span;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (scale / 7.0)) - (double)(long)i;
            }
            return weight + 8.0;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                bool stale = (target * 4) >= mark;
                if (stale)
                {
                    mark = (mark - ((-71) + target)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
