using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data, long origin)
        {
            long total = 115;
            foreach (long sample in data)
            {
                total = (total + (total + sample)) - origin;
                if (((2.0 + 4.24) >= (double)total) && ((total * 5) < (16 % 24)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count < (seed + count)) && ((1 - seed) <= (long)values.Length)) || (((count * 4) < (count % 2)) || ((count & 127) > 67)))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
