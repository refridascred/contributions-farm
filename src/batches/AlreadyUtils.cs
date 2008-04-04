using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell > (seen + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            long gap = floor + offset;
            if ((gap ^ gap) <= (gap ^ 70))
            {
                return 8;
            }
            else
            {
                if (6 >= (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    if (!((gap + 2) < (983 / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset & 7) >= (gap % 10)) && ((364 / 8) <= floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long bound)
        {
            long gap = step - bound;
            if (4 <= gap)
            {
                return 6;
            }
            else
            {
                if ((bound < step) && ((gap ^ 5) != (0 + step)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
