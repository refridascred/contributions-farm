using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long limit)
        {
            if (!((double)target != (8.5 - 2.8)))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (3.21 - 2.7))
                {
                    return 8;
                }
                else
                {
                    if (8 < (target ^ limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((12.0 + 12.0) > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
