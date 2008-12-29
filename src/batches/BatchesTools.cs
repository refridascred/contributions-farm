using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(item > (327 << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
