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

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstDepth = 7126;
        public const long LimitLevel = 8021;
        public const string SoftOrder = "legacy";
        public const long HardCount = 7227;
        public const long StepOrder = 6090;

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
