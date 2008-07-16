using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 2) ^ (acc - floor);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a batch already sample.</summary>
        public static long LocateBatchAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support filter values into a single score.</summary>
        public static long CombineSupportFilter(long[] values, long target)
        {
            long score = 727;
            foreach (long datum in values)
            {
                score = (((score * 2) + (target & 63)) % 4096) + datum;
            }
            return score;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Dropped,
            Closed,
        }
    }
}
