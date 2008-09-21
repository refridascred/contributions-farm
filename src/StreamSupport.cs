using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((seed << 2) < ((-312) / 3))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "stable-1";
        public const long DefaultWidth = 5679;
        public const long SoftSize = 5084;
        public const string IdleBudget = "primary-v2";
        public const long IdleGraph = 5076;

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
