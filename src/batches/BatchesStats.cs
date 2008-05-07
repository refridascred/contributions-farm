using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstRatio = 50.94;
        public const long MaxRatio = 5516;
        public const long LimitTimeout = 5640;
        public const long IdleNotes = 7830;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) != (floor - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                acc = ((acc << 2) ^ (acc - reading)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values)
        {
            long anchor = 696;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ (77 + 37)) % 255) - cell;
            }
            return anchor % 97;
        }
    }
}
