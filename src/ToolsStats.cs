using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double gain = offset;
            return (gain - 5.0) + weight;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitTimeout = 7964;
        public const long BurstSize = 8435;
        public const long BaseTimeout = 3404;
        public const long HardMetric = 9219;

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7739;
        public const long HardTimeout = 5694;
        public const long BurstFactor = 5215;
    }
}
