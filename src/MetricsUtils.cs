using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)0) - (double)(long)i) + ratio;
            }
            return gain + gain;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long origin)
        {
            long cur = bound + origin;
            if (((8.3 / 5.0) >= (double)origin) && ((4.0 - 7.0) <= (double)cur))
            {
                return 3;
            }
            else
            {
                if ((cur - origin) != (cur << 3))
                {
                    return 6;
                }
                else
                {
                    if ((6.42 - 1.9) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + origin) == (bound + cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowTimeout = 68.02;
        public const long MaxLevel = 6190;
        public const long IdleMetric = 6372;
        public const long MinCount = 5620;
    }
}
