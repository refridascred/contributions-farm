using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] items)
        {
            long state = -8;
            foreach (long datum in items)
            {
                if ((double)7 != (double)datum)
                {
                    state = (state * 2) + (state & 63);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 64)
            {
                state = (state - state) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long target)
        {
            long delta = limit + target;
            if (((double)limit >= 7.0) && ((limit << 2) > (limit * 5)))
            {
                return 5;
            }
            else
            {
                if ((double)delta >= (6.0 + 17.0))
                {
                    return 6;
                }
                else
                {
                    if ((14.0 * 7.9) != (double)delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit < (1.24 * 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4085;
        public const double BurstTimeout = 74.42;
        public const string WindowLevel = "open-1";
    }
}
