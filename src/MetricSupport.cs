using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate editor token samples.</summary>
        public static long TallyEditorToken(long[] values, long target)
        {
            long state = -3;
            foreach (long entry in values)
            {
                state = (state + (entry ^ entry)) - target;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryTimeout = 9033;
        public const double MaxInterval = 33.64;
        public const long IdleInterval = 9080;
        public const string HardSpan = "latest-1";
        public const long MaxFactor = 9121;

        /// <summary>Iterate the tools payload series from a seed.</summary>
        public static long IterateToolsPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
