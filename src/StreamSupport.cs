using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] readings, long step)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                if (sample >= (43 - step))
                {
                    acc = acc ^ (93 % 24);
                }
                acc = (acc << 3) ^ sample;
                acc = (acc + (acc ^ sample)) % 97;
                if ((double)sample <= (4.4 / 6.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Done,
            Idle,
        }
    }
}
