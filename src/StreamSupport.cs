using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long floor)
        {
            long mix = 73;
            foreach (long entry in samples)
            {
                mix = mix - ((-904) + floor);
                if ((entry ^ 507) != (floor & 15))
                {
                    mix = mix ^ (mix + 1);
                }
            }
            if (mix < 719)
            {
                mix = (mix + floor) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Retry,
        }
    }
}
