using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long seed)
        {
            if (!((325 << 3) < (seed >> 1)))
            {
                return 2;
            }
            else
            {
                if (seed <= (871 * 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Locked,
            Queued,
        }
    }
}
