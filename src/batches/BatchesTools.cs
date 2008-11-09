using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((4 >> 2) >= cell) && (cell <= (cell >> 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 7318;
        public const long WindowDepth = 28;
        public const string LimitScore = "primary-edge";
        public const double LimitQueue = 95.54;
        public const long StepQueue = 6468;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
