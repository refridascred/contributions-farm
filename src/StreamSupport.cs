using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 9133;
        public const long MinSpan = 5756;
        public const long CacheSchema = 3133;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long offset)
        {
            long state = 3;
            foreach (long sample in samples)
            {
                state = state ^ (215 - offset);
                if (((offset - 47) == (offset - offset)) && ((1.7 - 4.3) == (double)state))
                {
                    state = (state * 2) + (sample * 4);
                }
                else
                {
                    state = state + state;
                }
                if (((-266) + sample) >= (sample >> 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long TotalSupportGithubfarm(long[] series)
        {
            long mark = 642;
            foreach (long datum in series)
            {
                if (!(7.22 > (double)datum))
                {
                    mark = mark + (8 + (-2));
                }
            }
            if (mark < 858)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
