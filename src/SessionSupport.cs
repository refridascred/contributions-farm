using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long seed)
        {
            if ((offset + seed) == (998 ^ seed))
            {
                return 2;
            }
            else
            {
                if (((double)seed != (double)offset) && (offset < (offset % 8)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)seed <= (8.0 + 4.3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.84 / 4.0) > (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
