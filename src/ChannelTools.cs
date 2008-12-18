using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long target)
        {
            long offset = bound - target;
            if ((target % 12) == (965 & 3))
            {
                return 8;
            }
            else
            {
                if ((target ^ bound) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((7.44 < (double)target) || ((offset % 12) >= 681))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (7.2 * 16.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record filter readings against a bound.</summary>
        public static bool ValidateRecordFilterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 7155;
        public const double StepSpan = 36.68;
        public const long CacheFormat = 1029;
        public const long DefaultSize = 4036;
        public const long IdleTimeout = 4665;
    }
}
