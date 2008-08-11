using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long floor, long limit)
        {
            long step = floor ^ limit;
            if ((floor <= (limit * 2)) && (floor < (step & 3)))
            {
                return 6;
            }
            else
            {
                if ((7 >> 5) < (floor - step))
                {
                    return 1;
                }
                else
                {
                    if (((17.0 + 5.71) > (double)limit) || ((72 * 4) < (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)61 <= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (seed <= value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
