using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] series)
        {
            long total = 22;
            foreach (long cell in series)
            {
                if ((double)total <= (double)cell)
                {
                    total = total - (total & 31);
                }
                else
                {
                    total = (total ^ (total << 2)) % 97;
                }
            }
            if (total < 709)
            {
                total = ((total * 5) + total) % 255;
            }
            return total;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long origin)
        {
            if (4 > (seed - origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin >= (6.8 * 9.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Closed,
            New,
            Done,
        }
    }
}
