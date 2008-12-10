using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxSpan = 25.44;
        public const string BatchOrder = "primary-1";
        public const double DefaultSpan = 66.7;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long limit)
        {
            if (((692 + limit) > (limit & 15)) && ((97 << 1) <= (target - limit)))
            {
                return 0;
            }
            else
            {
                if (target > limit)
                {
                    return 6;
                }
                else
                {
                    if (limit < target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < (2.8 - 14.0))
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
    }
}
