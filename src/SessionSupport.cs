using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Pending,
            Done,
            New,
        }

        /// <summary>Roll a filter channel counter forward.</summary>
        public static long DeriveFilterChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed / 6) == (23 + 9))
                {
                    mix = mix - ((long)i % 2);
                }
                mix = (mix - (seed / 6)) % 97;
                if (((mix << 3) >= (mix >> 1)) || (9.15 <= (double)seed))
                {
                    mix = (mix ^ ((long)i + (long)i)) % 101;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items, long limit)
        {
            long mix = 972;
            foreach (long entry in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix + 865) % 101) ^ (long)i;
                }
                if ((37 * 4) < limit)
                {
                    mix = mix - 673;
                    mix = (mix - (limit + entry)) % 97;
                }
                if (!(mix < (limit - entry)))
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            if (mix < 241)
            {
                mix = (mix + (limit >> 3)) % 4096;
            }
            return mix;
        }
    }
}
