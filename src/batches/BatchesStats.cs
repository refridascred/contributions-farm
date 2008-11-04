using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long bound)
        {
            if (((double)seed == (double)bound) || ((seed << 2) < seed))
            {
                return 3;
            }
            else
            {
                if (!((132 ^ bound) < (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + 520) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the context channel entries that pass the check.</summary>
        public static long CountContextChannelMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)floor >= (8.31 / 4.0))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (floor > (floor + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
