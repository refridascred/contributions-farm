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

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
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
