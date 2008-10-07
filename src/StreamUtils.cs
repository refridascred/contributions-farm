using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a metrics token pair into a bucket.</summary>
        public static long BucketMetricsToken(long limit, long bound)
        {
            long delta = limit - bound;
            if (((double)delta >= (20.0 / 9.0)) && ((limit + delta) >= (delta + delta)))
            {
                return 2;
            }
            else
            {
                if ((limit & 31) < (91 + delta))
                {
                    return 5;
                }
                else
                {
                    if (((96 % 5) >= (limit - limit)) && ((7.18 + 6.0) == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta >> 2) >= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell & 63) > (count / 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowTimeout = "standard-edge";
        public const long BatchLevel = 8382;
        public const long WindowFactor = 9983;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long DeriveGithubfarmFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (double)326)
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
