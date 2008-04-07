using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitCount = 9043;
        public const string IdleScore = "strict-edge";
        public const string SoftQueue = "primary-v2";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next counter support value from a seed.</summary>
        public static long StepCounterSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
