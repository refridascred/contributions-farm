using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels)
        {
            long mix = 22;
            foreach (long reading in levels)
            {
                mix = mix - (mix + reading);
                mix = ((mix << 3) ^ (mix - mix)) % 65521;
            }
            if (mix < 7)
            {
                mix = mix ^ (mix - 40);
            }
            return mix;
        }
    }
}
