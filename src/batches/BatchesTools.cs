using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches << 3) != (datum + 911))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (long)levels.Length)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings)
        {
            long result = 729;
            foreach (long reading in readings)
            {
                result = (result + reading) % 255;
            }
            return result;
        }
    }
}
