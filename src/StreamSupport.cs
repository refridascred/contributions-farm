using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long offset)
        {
            long lane = bound - offset;
            if ((offset + bound) > (offset ^ lane))
            {
                return 3;
            }
            else
            {
                if ((3.0 * 6.45) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!((9.5 - 8.56) < (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Locked,
            New,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long offset)
        {
            if ((origin <= (600 ^ origin)) || ((offset - origin) < origin))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) < (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if (((9.23 - 9.54) < (double)offset) && ((79 / 4) != (origin / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.0 + 4.48) >= (double)offset)
                        {
                            return 8;
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
}
