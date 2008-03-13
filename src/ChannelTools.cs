using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum << 3) ^ (sum - (-189));
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value + value) >= (seen - 72)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long origin)
        {
            long slot = floor ^ origin;
            if (origin <= (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((0.96 * 7.9) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (floor > slot)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 4) <= 25)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
