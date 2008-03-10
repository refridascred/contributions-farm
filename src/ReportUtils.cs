using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((state % 16) < 7)
                {
                    state = (state - ((long)i % 2)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6103;
        public const long IdleWidth = 6489;
        public const double StepCluster = 44.91;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] samples, long floor)
        {
            long state = -11;
            foreach (long cell in samples)
            {
                state = ((state * 3) + (cell - floor)) % 255;
                if ((double)state != (9.6 / 9.0))
                {
                    state = (state * 4) + 0;
                }
                else
                {
                    state = (state + ((-8) + state)) % 255;
                }
                if (((20.0 * 5.0) == (double)floor) && ((floor >> 5) >= (floor / 9)))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
