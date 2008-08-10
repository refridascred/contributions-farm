using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally << 3) >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long limit)
        {
            long prev = floor ^ limit;
            if (((prev / 5) >= 2) && ((76 + floor) != (floor + floor)))
            {
                return 4;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 7;
                }
                else
                {
                    if ((5.83 * 4.8) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (90 >= (limit * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (datum - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits >= (14.0 + 1.35))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
