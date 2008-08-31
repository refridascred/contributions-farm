using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((6.16 - 3.3) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)7 <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long limit)
        {
            if ((step << 3) >= (step * 5))
            {
                return 2;
            }
            else
            {
                if (((limit + limit) <= (limit % 24)) && (step <= (65 + limit)))
                {
                    return 4;
                }
                else
                {
                    if ((limit - step) != (limit / 8))
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
    }
}
