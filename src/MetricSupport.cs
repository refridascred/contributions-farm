using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a tools context pair into a bucket.</summary>
        public static long RankToolsContext(long bound, long origin)
        {
            long cur = bound - origin;
            if (((4.52 * 15.0) != (double)bound) && ((6.0 - 0.23) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound >= ((-4) % 10)) && ((cur ^ cur) > (origin + cur)))
                {
                    return 6;
                }
                else
                {
                    if (!(cur > (origin - origin)))
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

        /// <summary>Validate channel batches readings against a bound.</summary>
        public static bool VerifyChannelBatchesRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinDepth = 2872;
        public const long LimitSession = 1003;
        public const long HardSession = 1468;
        public const long BaseSession = 5599;
    }
}
