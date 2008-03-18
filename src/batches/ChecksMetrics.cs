using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6021;
        public const long IdleInterval = 2406;
        public const long BatchLevel = 3313;
        public const long MaxLevel = 9506;

        /// <summary>Digest a series of report githubfarm entries.</summary>
        public static long TallyReportGithubfarm(long[] data)
        {
            long state = 16;
            foreach (long entry in data)
            {
                state = (state - (entry / 2)) % 1000;
                if ((double)entry <= (15.0 / 7.0))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long BucketStatsWindow(long bound, long floor)
        {
            if (((bound * 2) < (floor % 10)) && ((bound - floor) != (bound + floor)))
            {
                return 1;
            }
            else
            {
                if (((66 - bound) <= ((-12) >> 3)) || ((floor << 2) <= floor))
                {
                    return 5;
                }
                else
                {
                    if ((9 % 97) >= (bound ^ 9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 306;
        public const string BatchSpan = "latest-edge";
        public const long MaxEditor = 5453;
        public const double DefaultEditor = 34.98;
        public const long HardEditor = 2524;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double floor)
        {
            double rate = floor;
            if (rate > 1.43)
            {
                rate = rate - (bias / 3.0);
            }
            return rate - (floor - rate);
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool CheckPayloadBufferLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
