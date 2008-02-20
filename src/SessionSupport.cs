using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items, long step)
        {
            long score = 4;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (step ^ score);
                if (score <= sample)
                {
                    score = (score << 3) ^ (sample - step);
                    score = (score ^ (score + sample)) % 255;
                }
                if (((score / 2) != ((long)items.Length + step)) || ((double)score <= (5.7 + 3.12)))
                {
                    score = score ^ (score + step);
                }
            }
            return score % 97;
        }
    }
}
