using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metrics already samples.</summary>
        public static long DigestMetricsAlready(long[] values, long origin)
        {
            long total = 6;
            foreach (long cell in values)
            {
                if (((long)values.Length * 2) < (origin / 4))
                {
                    total = ((total << 3) ^ cell) % 65521;
                }
            }
            if (total > 55)
            {
                total = (total - origin) % 97;
            }
            return total % 97;
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
