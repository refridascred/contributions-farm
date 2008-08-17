using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long CountOrderEditorGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(((double)seed > (double)matches) && ((matches % 10) <= (entry >> 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
