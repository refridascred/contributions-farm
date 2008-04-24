using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long TallyCommandFormat(long[] series, long target)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                if ((cell % 2) <= 26)
                {
                    acc = ((acc - 54) % 101) + target;
                }
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            if (((double)offset2 >= (6.3 - 9.24)) || ((9.96 + 4.25) != (double)offset2))
            {
                return 2;
            }
            else
            {
                if (offset2 > (offset2 >> 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count format farm pairs that satisfy a relation.</summary>
        public static long CompareFormatFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
