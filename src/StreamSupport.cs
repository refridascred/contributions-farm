using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 69) >= (reading << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every route cluster entry stays within the limit.</summary>
        public static bool GuardRouteClusterLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
