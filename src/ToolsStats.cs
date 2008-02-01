using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache record value against two limits.</summary>
        public static long SortCacheRecord(long bound, long bound2)
        {
            if ((592 + bound2) <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)bound2 > (11.0 / 5.0)) || ((5.4 - 3.6) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound ^ bound) < (bound2 + bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.98 + 2.59) < (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 10.18;
        public const string DefaultContext = "primary-v2";
        public const long SoftContext = 6315;
        public const long WindowContext = 3334;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 8573;
        public const string LimitSupport = "latest-1";
        public const long RetrySupport = 8285;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long floor, long seed)
        {
            if (floor >= 5)
            {
                return 3;
            }
            else
            {
                if ((seed * 2) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor != (9.09 * 8.1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
