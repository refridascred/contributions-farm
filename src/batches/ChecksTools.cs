using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Draft,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long step, long floor)
        {
            if ((step - floor) != (floor & 31))
            {
                return 7;
            }
            else
            {
                if (((1 << 1) >= (step + floor)) || (0 < floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
