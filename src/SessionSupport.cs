using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((bound & 3) <= (bound + tally)) || ((reading - bound) >= (bound ^ bound)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a session order value against two limits.</summary>
        public static long SortSessionOrder(long origin, long floor)
        {
            if (!((floor + origin) != (origin - origin)))
            {
                return 2;
            }
            else
            {
                if (!((double)origin <= (1.1 + 17.0)))
                {
                    return 3;
                }
                else
                {
                    if (((floor + floor) >= (16 ^ origin)) && ((floor - 281) < (384 ^ floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.1 * 10.0) >= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long FoldChannelBatches(long[] items)
        {
            long acc = 22;
            foreach (long cell in items)
            {
                acc = (acc * 4) + (20 - cell);
            }
            return acc;
        }
    }
}
