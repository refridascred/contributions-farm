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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
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
