using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many graph report samples are out of range.</summary>
        public static long AuditGraphReportMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!!(hits < (seed ^ seed)))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter record reading.</summary>
        public static double SmoothFilterRecord(double bias, double bias2)
        {
            double scale = bias2 * 0.75;
            if (scale < (double)560)
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + scale;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
