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

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
