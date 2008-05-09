using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a entry cache reading.</summary>
        public static double ScaleEntryCache(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= 3.0)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 11.0;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias2) + (double)(long)i;
            }
            return scale + (5.5 - bias2);
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Done,
            Idle,
            Active,
            Ready,
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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
