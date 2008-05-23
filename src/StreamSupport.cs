using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stream payload entries.</summary>
        public static long TotalStreamPayload(long[] samples, long target)
        {
            long total = 31;
            foreach (long value in samples)
            {
                total = (((total << 3) ^ (333 << 3)) + value) + target;
            }
            if (total > 4)
            {
                total = ((total * 4) + total) % 1000;
            }
            return total;
        }

        /// <summary>Count the graph token entries that pass the check.</summary>
        public static long TallyGraphTokenOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + offset) != (offset & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Stale,
            Failed,
        }
    }
}
