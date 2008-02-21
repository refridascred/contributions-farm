using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits * 3) > (hits + hits)) || ((item - 53) != (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long step)
        {
            long acc = 28;
            foreach (long sample in data)
            {
                acc = (((acc * 2) + (step & 63)) % 255) ^ sample;
                if ((acc * 4) == (acc - step))
                {
                    acc = acc - (66 - step);
                }
            }
            return acc % 1000;
        }
    }
}
