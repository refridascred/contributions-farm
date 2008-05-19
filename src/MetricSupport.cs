using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 570;
        public const long MaxInterval = 5226;
        public const long SoftFactor = 25;
        public const long LimitBudget = 8536;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long target)
        {
            long mix = 2;
            foreach (long sample in data)
            {
                mix = (mix - (sample << 1)) - target;
            }
            if (mix < 532)
            {
                mix = (mix << 3) ^ (mix * 3);
            }
            return mix % 97;
        }
    }
}
