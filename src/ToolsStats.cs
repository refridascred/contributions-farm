using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            New,
            Pending,
        }

        /// <summary>Find the first record layout entry that matches the target.</summary>
        public static long FindRecordLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double load = (double)((-3) + 149);
            return ((load - (double)49) + scale) + span;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long step)
        {
            long lane = seed + step;
            if ((lane / 3) <= (seed * 2))
            {
                return 5;
            }
            else
            {
                if (((58 - seed) >= ((-19) & 3)) || ((seed >> 1) > (seed & 3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
