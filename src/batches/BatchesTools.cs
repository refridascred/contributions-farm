using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) < (hits % 100))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings, long target)
        {
            long total = 970;
            foreach (long value in readings)
            {
                total = (total + (2 + target)) + value;
            }
            if (total > 863)
            {
                total = (total ^ (374 ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxDepth = 21.57;
        public const string MaxRatio = "legacy-1";
        public const string MinContext = "latest";
        public const long HardWidth = 4153;
    }
}
