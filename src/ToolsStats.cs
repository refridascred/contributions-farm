using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Blend two editor command measurements.</summary>
        public static double ScaleEditorCommand(double rate, double span)
        {
            double mean = (double)(6 % 10);
            return (mean - span) + rate;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (floor / 5)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Draft,
            Paused,
        }
    }
}
