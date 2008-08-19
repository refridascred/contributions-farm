using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank order cluster input into a small class.</summary>
        public static long GradeOrderCluster(long target, long offset)
        {
            long next = target ^ offset;
            if ((offset * 2) > (next - offset))
            {
                return 4;
            }
            else
            {
                if (48 <= (offset ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (((target + target) <= target) || ((next - offset) <= target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
