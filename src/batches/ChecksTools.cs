using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long origin, long target)
        {
            if ((double)target != (0.6 - 1.1))
            {
                return 5;
            }
            else
            {
                if (!((target - target) < (origin + origin)))
                {
                    return 2;
                }
                else
                {
                    if (target > (origin / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Paused,
        }
    }
}
