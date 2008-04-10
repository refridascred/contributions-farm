using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels, long target)
        {
            long acc = 0;
            foreach (long entry in levels)
            {
                acc = (((acc ^ acc) % 101) ^ entry) + target;
            }
            if (acc < 35)
            {
                acc = (acc << 3) ^ (acc - (long)levels.Length);
            }
            return acc;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((double)offset2 == (8.8 - 8.0))
            {
                return 8;
            }
            else
            {
                if (8.79 > (double)offset2)
                {
                    return 5;
                }
                else
                {
                    if (offset <= offset3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
