using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits & 3) < (sample + 722))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long limit)
        {
            if (!((4.3 - 9.43) < (double)limit))
            {
                return 0;
            }
            else
            {
                if (!((8 + floor) <= (floor ^ floor)))
                {
                    return 3;
                }
                else
                {
                    if ((96 % 7) >= (limit / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Closed,
            Dropped,
        }
    }
}
