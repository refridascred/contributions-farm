using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long mix = -6;
            foreach (long item in values)
            {
                if (!((double)item >= 8.1))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 69)
            {
                mix = ((mix * 5) + (mix / 4)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Draft,
            Paused,
        }
    }
}
