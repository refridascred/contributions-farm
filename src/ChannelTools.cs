using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + mix;
                mix = mix - mix;
                if (!((3 + mix) <= ((long)i * 2)))
                {
                    mix = (mix * 5) + (bound >> 5);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ (offset * 5)) % 1000) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
