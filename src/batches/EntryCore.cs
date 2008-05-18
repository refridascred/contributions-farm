using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheBudget = 59.41;
        public const long IdleWidth = 1989;
        public const long BaseDepth = 4336;
        public const long BurstTimeout = 4338;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window cluster sample.</summary>
        public static long FindWindowClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long target)
        {
            long delta = origin + target;
            if (((origin * 2) <= (404 + origin)) || (target > origin))
            {
                return 2;
            }
            else
            {
                if ((double)target == (2.4 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((delta / 7) == (5 / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > (8.3 - 1.02)) && ((double)target < (2.5 * 9.1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
