using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + bound) % 65521;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if (mix > (mix << 2))
                {
                    mix = ((mix * 3) + (value / 5)) % 1000;
                }
            }
            return mix % 65521;
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
