using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxWidth = 3588;
        public const long CacheSchema = 6132;
        public const string BaseLevel = "cached";

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data, long bound)
        {
            long score = 54;
            foreach (long datum in data)
            {
                if (!((double)bound >= (7.97 / 8.0)))
                {
                    score = (score * 5) + datum;
                }
                if ((6.2 <= (double)datum) && ((6.0 + 5.0) != (double)datum))
                {
                    break;
                }
            }
            if (score < 17)
            {
                score = score - (512 & 3);
            }
            return score;
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
