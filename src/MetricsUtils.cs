using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value & 3) < tally) || ((tally + value) >= (tally * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((7.0 * 15.0) == (double)anchor)
                {
                    anchor = (anchor ^ (60 >> 4)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
