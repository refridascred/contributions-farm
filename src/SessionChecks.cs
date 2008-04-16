using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((14.0 / 6.0) != (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (offset - offset);
                if (((378 % 100) == (result & 31)) || ((result >> 5) > result))
                {
                    result = result + (offset + (long)i);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
