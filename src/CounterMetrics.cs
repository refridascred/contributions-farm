using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstFactor = "latest-edge";
        public const long MaxContext = 1503;
        public const long MaxInterval = 6431;
        public const long LimitFactor = 8767;
        public const long MaxDepth = 9551;

        /// <summary>Measure how many account buffer samples are out of range.</summary>
        public static long TallyAccountBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((seen * 4) <= 1) || (seen <= (seen << 2))))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchInterval = "local";
        public const double StepReport = 83.72;
        public const string RetryFactor = "staging";
    }
}
