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

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if ((double)target2 != (9.8 * 3.0))
            {
                return 8;
            }
            else
            {
                if (target <= (target2 * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
