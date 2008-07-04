using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long limit)
        {
            if ((5.3 + 16.0) == (double)seed)
            {
                return 1;
            }
            else
            {
                if ((limit + 286) >= (291 + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit << 2) == (916 + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Pending,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((8.2 * 3.97) != (double)origin))
                {
                    sum = (sum * 4) + (sum * 3);
                }
                else
                {
                    sum = sum ^ (sum - sum);
                }
                sum = sum + origin;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long origin, long seed)
        {
            if (seed >= (seed & 31))
            {
                return 1;
            }
            else
            {
                if ((seed >> 2) > (origin >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((seed + origin) >= origin) || ((seed / 9) >= 59))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - origin) == (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Paused,
            Pending,
            Locked,
            Retry,
        }
    }
}
