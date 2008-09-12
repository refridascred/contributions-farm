using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxBudget = 1866;
        public const long DefaultProfile = 8030;
        public const long BaseTimeout = 273;
        public const long BatchProfile = 7452;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items, long seed)
        {
            long state = -71;
            foreach (long entry in items)
            {
                if ((seed * 5) >= (state / 7))
                {
                    state = ((state + state) % 4096) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a notes support sample.</summary>
        public static long SeekNotesSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double SmoothRouteProfile(double bias, double offset)
        {
            double load = offset * 8.99;
            if (load < bias)
            {
                load = load - bias;
            }
            else
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (3.36 - bias)) - (double)(long)i;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Derive the next commits command value from a seed.</summary>
        public static long SeriesCommitsCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
