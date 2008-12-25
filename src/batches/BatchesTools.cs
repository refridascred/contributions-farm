using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Retry,
            Active,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double scale = (double)27;
            return ((scale - (double)852) + gain) + floor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if ((sample ^ sample) != ((long)values.Length - sample))
                {
                    mix = mix ^ (sample >> 4);
                }
                if ((mix >= (sample - mix)) || ((mix << 2) != (sample - 4)))
                {
                    mix = ((mix * 5) + (mix << 3)) % 4096;
                }
                else
                {
                    mix = (mix + 684) % 255;
                }
            }
            if (mix > 0)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }
    }
}
