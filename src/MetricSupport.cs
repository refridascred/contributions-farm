using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseLevel = 9204;
        public const double MaxBuffer = 26.48;
        public const string IdleLevel = "cached-edge";
        public const long SoftCount = 6402;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            long diff = target ^ origin;
            if ((diff - target) >= diff)
            {
                return 5;
            }
            else
            {
                if ((94 << 2) != (diff & 63))
                {
                    return 2;
                }
                else
                {
                    if ((origin - target) >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ origin) != (99 - target))
                        {
                            return 1;
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
}
