using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long target2)
        {
            long bound = target - target2;
            if ((bound + 448) >= (target2 << 2))
            {
                return 5;
            }
            else
            {
                if ((target / 9) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Active,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Retry,
            Active,
            Idle,
        }
    }
}
