using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((offset & 3) <= (899 / 2))
            {
                return 5;
            }
            else
            {
                if (((diff >> 3) != (offset ^ (-223))) || ((offset ^ offset) > (offset & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((diff - offset) <= (878 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)offset != (5.2 - 6.93)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "stable";
        public const long HardSize = 5787;
        public const double CacheCommand = 63.09;
        public const string DefaultScore = "latest-1";

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long seed)
        {
            if ((9.2 + 1.0) < (double)limit)
            {
                return 6;
            }
            else
            {
                if (seed <= (4 >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((limit & 127) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit >= (4.9 * 1.58))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((7.9 - 0.1) < (double)seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
