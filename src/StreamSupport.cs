using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) > sample)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long seed)
        {
            long offset = origin - seed;
            if ((offset >> 2) < (origin + offset))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) >= (offset / 2))
                {
                    return 4;
                }
                else
                {
                    if ((19 << 3) < (origin - seed))
                    {
                        return 5;
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
