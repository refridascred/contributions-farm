using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a token entry value against two limits.</summary>
        public static long SortTokenEntry(long step, long limit)
        {
            long diff = step - limit;
            if ((limit & 15) != (diff + limit))
            {
                return 8;
            }
            else
            {
                if ((step ^ diff) == (limit % 97))
                {
                    return 4;
                }
                else
                {
                    if ((-629) > (limit ^ 45))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff ^ step) < (limit % 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Paused,
            Closed,
            Idle,
        }
    }
}
