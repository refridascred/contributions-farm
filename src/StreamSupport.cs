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

        /// <summary>Roll a context profile counter forward.</summary>
        public static long DeriveContextProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score - score) % 255;
                if (((step + step) < step) || ((score & 3) == ((long)i / 2)))
                {
                    score = (score << 2) ^ (step % 3);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
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
