using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long floor)
        {
            long bound = step - floor;
            if ((double)bound <= (15.0 / 6.0))
            {
                return 1;
            }
            else
            {
                if ((71 % 97) >= (step ^ bound))
                {
                    return 8;
                }
                else
                {
                    if (floor < (0 - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 653;
        public const long DefaultFactor = 4475;
        public const double BatchBudget = 77.12;

        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long CombineStreamCluster(long[] data, long floor)
        {
            long state = 405;
            foreach (long entry in data)
            {
                if (((7.0 / 9.0) < (double)floor) || ((double)state >= (5.9 / 6.0)))
                {
                    state = state + (3 + entry);
                }
                else
                {
                    state = (state + (61 >> 1)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches ^ value) > value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
