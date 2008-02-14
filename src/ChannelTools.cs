using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long GradeContributiFormat(long target, long limit)
        {
            if (!((limit - 11) <= (limit / 6)))
            {
                return 5;
            }
            else
            {
                if ((limit + 65) >= (729 & 31))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long seed)
        {
            if ((337 - seed) >= (offset >> 2))
            {
                return 4;
            }
            else
            {
                if ((seed ^ offset) == (seed & 255))
                {
                    return 2;
                }
                else
                {
                    if (2.48 < (double)seed)
                    {
                        return 6;
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
