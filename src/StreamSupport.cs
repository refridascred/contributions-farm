using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long target, long step)
        {
            long delta = target ^ step;
            if ((double)step == (double)delta)
            {
                return 3;
            }
            else
            {
                if (!((double)target == (9.32 * 4.89)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
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
