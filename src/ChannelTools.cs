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

        /// <summary>Iterate the support metric series from a seed.</summary>
        public static long IterateSupportMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((18.0 / 3.0) >= (double)offset) || ((offset + (long)i) >= acc))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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
