using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Draft,
            Active,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double gain = (double)352 - (bias + scale);
            if (gain < scale)
            {
                gain = gain - (bias + gain);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (scale / 2.0);
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
