using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Idle,
            Pending,
            Done,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((16.0 * 8.66) > (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            if ((origin % 16) >= (floor % 60))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < (origin << 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
