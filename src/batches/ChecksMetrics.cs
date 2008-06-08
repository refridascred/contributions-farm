using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long limit)
        {
            long cur = step - limit;
            if ((limit - step) < (936 - step))
            {
                return 7;
            }
            else
            {
                if (((double)cur == (double)limit) && ((9.18 / 7.0) >= (double)step))
                {
                    return 4;
                }
                else
                {
                    if (5 >= cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if (648 >= (cur & 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the route farm series from a seed.</summary>
        public static long IterateRouteFarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = state + (offset << 2);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if (bound <= (offset * 3))
            {
                return 0;
            }
            else
            {
                if (((double)bound > 3.9) && (offset < (offset / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 100) >= (offset ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 / 6.0) == (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 362;
        public const long SoftDepth = 856;
        public const long HardFarm = 5132;
        public const string DefaultFarm = "local-1";
        public const string BurstSize = "alpha";
    }
}
