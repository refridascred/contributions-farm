using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next record schema value.</summary>
        public static double BlendRecordSchema(double ratio, double floor)
        {
            double load = floor + (ratio / 2.0);
            for (int i = 0; i < 5; i++)
            {
                load = (load - 8.8) - (double)(long)i;
            }
            return load + (double)0;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Stale,
            Pending,
        }
    }
}
