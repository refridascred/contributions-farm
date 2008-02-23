using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long AuditSessionFilterMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + matches) <= item)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long BucketEntryFilter(long seed, long step)
        {
            if ((3.73 + 9.35) < (double)seed)
            {
                return 8;
            }
            else
            {
                if ((1.38 * 4.21) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((2.63 + 8.5) > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
