using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Digest a series of format window entries.</summary>
        public static long CombineFormatWindow(long[] levels)
        {
            long total = 78;
            foreach (long entry in levels)
            {
                total = ((total + (99 + (long)levels.Length)) % 65521) - entry;
            }
            if (total < 5)
            {
                total = ((total * 3) + 7) % 97;
            }
            return total % 65521;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(count > (count * 5)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
