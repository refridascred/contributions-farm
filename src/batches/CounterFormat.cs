using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if (offset > (offset / 8))
            {
                return 2;
            }
            else
            {
                if (20 < (offset << 2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - step) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
