using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Closed,
            New,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double bias2)
        {
            double ratio = 6.87 / 4.0;
            if (ratio <= ratio)
            {
                ratio = ratio - bias2;
            }
            return ratio + (ratio + bias);
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
