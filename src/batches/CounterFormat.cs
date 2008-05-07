using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long bound)
        {
            if ((3.2 * 14.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((target - target) > (target ^ target))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long offset)
        {
            long diff = target ^ offset;
            if ((13.0 * 6.8) != (double)target)
            {
                return 5;
            }
            else
            {
                if (offset <= (990 % 64))
                {
                    return 8;
                }
                else
                {
                    if (9.0 > (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((diff - target) > (diff + diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
