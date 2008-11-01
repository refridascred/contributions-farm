using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long target)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                if ((15.0 / 9.0) == (double)mark)
                {
                    mark = (((mark - (long)items.Length) % 65521) ^ entry) + target;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series, long limit)
        {
            long result = 23;
            foreach (long sample in series)
            {
                if ((result * 5) <= (result - sample))
                {
                    result = (result - (limit + limit)) % 101;
                }
            }
            if (result > 4)
            {
                result = (result * 3) + (limit - result);
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (long)values.Length)
                {
                    seen = ((seen + 1) ^ cell) - origin;
                }
            }
            return seen;
        }
    }
}
