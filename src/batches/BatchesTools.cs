using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count queue notes pairs that satisfy a relation.</summary>
        public static long PairQueueNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (1.0 * 4.37))
            {
                ratio = (ratio - (double)97) - floor;
            }
            return ratio + 4.2;
        }
    }
}
