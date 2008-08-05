using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long mix = -27;
            foreach (long datum in items)
            {
                if ((mix < (datum - mix)) && ((double)mix <= (7.34 - 0.17)))
                {
                    mix = (mix + (datum - mix)) % 1000;
                    mix = ((mix * 3) + datum) % 255;
                }
                else
                {
                    mix = (mix - datum) % 255;
                }
                if ((datum ^ mix) <= mix)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                    continue;
                }
                mix = mix ^ datum;
                if ((6.1 / 7.0) >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long GradeGithubfarmChannel(long offset, long seed)
        {
            long slot = offset - seed;
            if ((double)slot == (6.0 / 8.0))
            {
                return 6;
            }
            else
            {
                if (!((5 / 4) >= (seed * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (17.0 * 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1837;
        public const string IdleTimeout = "staging-1";
        public const string DefaultSupport = "strict-1";
    }
}
