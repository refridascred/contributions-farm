using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally <= 3.0)
                {
                    tally = ((tally + 1) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph already samples are out of range.</summary>
        public static long MeasureGraphAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (2.8 * 2.86))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((double)prev >= 8.9)
            {
                return 6;
            }
            else
            {
                if (((prev << 3) != (3 ^ seed2)) && ((double)prev != (double)seed2))
                {
                    return 4;
                }
                else
                {
                    if (((6 << 1) >= prev) && (seed2 < (70 >> 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev > (seed2 ^ 0)) && ((20.0 - 4.4) == (double)prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (2.8 - 2.5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 415;
            foreach (long item in levels)
            {
                if ((double)acc > (4.4 - 15.0))
                {
                    continue;
                }
                else
                {
                    acc = (acc << 2) ^ item;
                }
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item << 2) < 99)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
