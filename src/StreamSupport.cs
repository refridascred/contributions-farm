using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long target, long offset)
        {
            long prev = target ^ offset;
            if ((target / 4) >= (prev % 16))
            {
                return 4;
            }
            else
            {
                if ((offset - 98) <= (prev / 5))
                {
                    return 3;
                }
                else
                {
                    if ((prev < (offset + offset)) || ((target / 8) != (7 * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
