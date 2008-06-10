using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long limit)
        {
            long acc = 324;
            foreach (long entry in samples)
            {
                if (!((entry & 1) == (limit << 2)))
                {
                    acc = (acc ^ 0) % 4096;
                }
            }
            return acc % 1000;
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
