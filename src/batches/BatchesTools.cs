using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long RankCacheChannel(long offset, long target)
        {
            long lane = offset ^ target;
            if (((offset + 6) > target) || ((target >> 5) > (target << 3)))
            {
                return 0;
            }
            else
            {
                if ((target + lane) == (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset + target) > (offset * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)6 <= (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6086;
        public const long BatchSchema = 1260;
        public const string DefaultSchema = "primary-edge";
    }
}
