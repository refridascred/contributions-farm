using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 6613;
        public const double CacheGithubfarm = 4.69;
        public const long DefaultGithubfarm = 8561;

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long DeriveGraphFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a context batch pair into a bucket.</summary>
        public static long SortContextBatch(long seed, long limit)
        {
            if ((5 - limit) <= seed)
            {
                return 5;
            }
            else
            {
                if (((seed % 12) <= (seed - limit)) && ((double)limit != (20.0 - 19.0)))
                {
                    return 6;
                }
                else
                {
                    if (((limit + limit) >= limit) || (limit <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - 377) == (limit + limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
