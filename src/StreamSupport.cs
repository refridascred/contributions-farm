using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Grade a window counter value against two limits.</summary>
        public static long RankWindowCounter(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((7.73 / 3.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((offset - next) <= offset)
                {
                    return 0;
                }
                else
                {
                    if ((next + limit) > next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
