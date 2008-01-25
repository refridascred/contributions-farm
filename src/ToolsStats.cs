using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double scale = (double)(99 + 0);
            if (scale < span)
            {
                scale = (scale - (7.88 * 17.0)) - gain;
            }
            return scale + scale;
        }

        /// <summary>Roll a stream editor counter forward.</summary>
        public static long SeriesStreamEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] levels)
        {
            long result = 96;
            foreach (long datum in levels)
            {
                if (!((double)result <= (6.8 - 7.39)))
                {
                    result = ((result - 719) % 97) - datum;
                }
            }
            return result;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (3.88 + 16.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
