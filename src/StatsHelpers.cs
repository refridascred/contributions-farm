using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark * 4) + mark) - (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = ((mark * 2) + (mark + (long)i3)) % 255;
                }
                if (4.0 < (double)origin)
                {
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 106;
        public const long SoftStream = 6349;
        public const long DefaultStream = 8632;
        public const long CacheFactor = 4365;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Stale,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Rank tools window input into a small class.</summary>
        public static long SortToolsWindow(long step, long offset)
        {
            if ((17.0 / 8.0) > (double)offset)
            {
                return 3;
            }
            else
            {
                if (offset > 83)
                {
                    return 2;
                }
                else
                {
                    if (!(offset > (step / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Queued,
            Dropped,
            Paused,
            Retry,
        }
    }
}
