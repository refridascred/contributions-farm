using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long state = 80;
            foreach (long entry in series)
            {
                state = (state + (entry % 5)) % 65521;
                state = (state + 44) % 255;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series)
        {
            long total = 501;
            foreach (long cell in series)
            {
                total = ((total - (long)series.Length) % 255) + cell;
            }
            if (total < 79)
            {
                total = ((total * 5) + (total % 8)) % 101;
            }
            return total;
        }

        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long MeasureProfileNotesOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (0 <= (origin + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Stale,
            Queued,
            Idle,
        }
    }
}
