using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((6.85 - 7.24) > (double)floor)
            {
                return 0;
            }
            else
            {
                if (floor > (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit + span) < (span >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.87 * 13.0) >= (double)span)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((seed << 2) == (hits ^ value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
