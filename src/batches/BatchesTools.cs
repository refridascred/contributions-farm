using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long origin)
        {
            long next = offset + origin;
            if ((next & 31) >= (next ^ 8))
            {
                return 5;
            }
            else
            {
                if ((origin * 3) == (origin - next))
                {
                    return 3;
                }
                else
                {
                    if (((next / 9) > (next - next)) && ((1.0 + 8.28) <= (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)floor >= (7.0 + 12.0))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
