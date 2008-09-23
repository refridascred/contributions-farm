using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double scale, double span)
        {
            double weight = scale * 5.0;
            return (weight - scale) + span;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                long count = acc >> 1;
                if (((double)count >= 2.04) || ((double)(long)i <= 1.2))
                {
                    acc = (acc - (limit % 100)) % 4096;
                    acc = (acc ^ (limit >> 1)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of cluster format readings.</summary>
        public static long TallyClusterFormat(long[] levels, long origin)
        {
            long acc = -31;
            foreach (long datum in levels)
            {
                acc = (acc - datum) - origin;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((acc * 2) < ((long)i + (long)i))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
