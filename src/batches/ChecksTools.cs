using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a token contributi reading.</summary>
        public static double ScaleTokenContributi(double gain, double bias)
        {
            double ratio = 2.1;
            if (ratio > (double)729)
            {
                ratio = ((ratio + ratio) - gain) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 9.88) + (double)(long)i;
            }
            return ratio - (6.94 / 8.0);
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
