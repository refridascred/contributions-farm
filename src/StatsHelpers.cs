using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series)
        {
            long state = 1;
            foreach (long cell in series)
            {
                if (state >= (state >> 2))
                {
                    state = (state * 4) + state;
                    continue;
                }
                if ((cell * 3) <= ((long)series.Length << 1))
                {
                    state = (state * 2) + cell;
                }
                else
                {
                    state = ((state * 5) + (cell >> 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin + origin) <= origin)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Queued,
            Dropped,
        }
    }
}
