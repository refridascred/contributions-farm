using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings)
        {
            long carry = -62;
            foreach (long cell in readings)
            {
                carry = carry - (cell + cell);
            }
            if (carry < (-310))
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Classify a session schema pair into a bucket.</summary>
        public static long BucketSessionSchema(long seed, long bound)
        {
            long offset = seed + bound;
            if ((offset + bound) > (seed % 16))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (double)3)
                {
                    return 8;
                }
                else
                {
                    if (bound < (95 << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long limit, long seed)
        {
            if ((858 / 5) != (seed + limit))
            {
                return 4;
            }
            else
            {
                if (!(limit <= (limit / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (0.78 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + (-25)) <= (limit + seed))
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
}
