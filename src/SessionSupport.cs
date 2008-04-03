using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long step)
        {
            if (((bound - step) > (step << 1)) && ((6.88 - 3.46) >= (double)bound))
            {
                return 5;
            }
            else
            {
                if (((step + bound) < 48) || (step < (step + (-421))))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (9 <= (count * 4))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
