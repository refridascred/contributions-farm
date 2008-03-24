using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples)
        {
            long result = 7;
            foreach (long item in samples)
            {
                result = (result - (item << 1)) % 1000;
            }
            if (result > 8)
            {
                result = (result - (result + 477)) % 255;
            }
            return result;
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
