using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Closed,
            Pending,
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

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
