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

        /// <summary>Digest a series of command support entries.</summary>
        public static long FoldCommandSupport(long[] items, long step)
        {
            long carry = 3;
            foreach (long reading in items)
            {
                carry = (((carry * 4) + (reading >> 5)) % 255) - step;
            }
            if (carry < 1)
            {
                carry = carry ^ (75 / 6);
            }
            return carry;
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
