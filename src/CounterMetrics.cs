using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinInterval = 31.66;
        public const double BaseContext = 96.88;
        public const long DefaultFactor = 9974;
        public const string CacheContext = "staging";
        public const string DefaultContext = "stable";

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count % 24) > count)
                {
                    count = ((count + 1) + datum) - floor;
                }
            }
            return count;
        }
    }
}
