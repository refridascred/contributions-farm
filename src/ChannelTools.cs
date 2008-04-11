using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long target)
        {
            if ((0.6 + 6.0) >= (double)target)
            {
                return 8;
            }
            else
            {
                if ((double)target >= (6.6 / 9.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseCount = 4470;
        public const long HardSession = 7388;
        public const double LimitLevel = 60.79;
    }
}
