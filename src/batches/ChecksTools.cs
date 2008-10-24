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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                long count = bound;
                mix = (mix - bound) % 255;
                mix = (mix ^ (bound - count)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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
