using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Failed,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long offset)
        {
            long lane = target - offset;
            if ((4 >> 2) <= (target / 5))
            {
                return 7;
            }
            else
            {
                if (lane <= (97 << 2))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
