using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series, long offset)
        {
            long mix = -425;
            foreach (long datum in series)
            {
                if ((((-757) - mix) < (datum / 8)) && ((double)mix < (4.0 - 5.0)))
                {
                    mix = (mix ^ (mix + offset)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (datum + mix)) % 97;
                }
                if ((offset + (long)series.Length) <= (mix ^ 97))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleInterval = 80.97;
        public const long HardGithubfarm = 5207;
        public const long BatchCount = 4845;
        public const long LimitGithubfarm = 14;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Paused,
            Synced,
            Idle,
            New,
        }
    }
}
