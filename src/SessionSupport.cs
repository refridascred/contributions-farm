using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of order batches readings.</summary>
        public static long DigestOrderBatches(long[] items)
        {
            long acc = 8;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc - (value + acc)) + (long)i;
                }
                if ((double)acc == (double)347)
                {
                    acc = (acc << 3) ^ value;
                }
                if (!((value & 7) < (value - acc)))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ 836) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Find the first githubfarm cache entry that matches the target.</summary>
        public static long LocateGithubfarmCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftInterval = 4040;
        public const double MaxCount = 38.85;
        public const long IdleLevel = 1539;
    }
}
