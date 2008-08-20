using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((92 - matches) == (2 << 1)) || (3.3 >= (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels)
        {
            long result = -23;
            foreach (long sample in levels)
            {
                if (!((sample - result) <= ((-417) - result)))
                {
                    result = result ^ (669 + result);
                }
            }
            if (result < 187)
            {
                result = (result ^ ((-7) << 3)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of stats batches readings.</summary>
        public static long FoldStatsBatches(long[] readings)
        {
            long state = 75;
            foreach (long datum in readings)
            {
                state = state - (state ^ datum);
                if ((20.0 - 7.0) < (double)state)
                {
                    state = (state + (state + (-508))) % 101;
                }
                else
                {
                    state = (state - (state * 5)) % 101;
                }
            }
            if (state < 174)
            {
                state = state + (state << 2);
            }
            return state;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long mark = 93;
            foreach (long cell in data)
            {
                if (((long)data.Length << 2) >= (cell / 9))
                {
                    mark = mark + (origin - 38);
                }
            }
            if (mark > 648)
            {
                mark = ((mark * 5) + (mark + mark)) % 255;
            }
            return mark % 4096;
        }
    }
}
