using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a session stats pair into a bucket.</summary>
        public static long GradeSessionStats(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((double)origin < (11.0 * 7.74))
            {
                return 6;
            }
            else
            {
                if (!((origin - 1) < (gap - gap)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
