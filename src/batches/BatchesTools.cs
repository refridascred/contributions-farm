using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "latest-1";
        public const double BaseRoute = 55.83;
        public const long MinFactor = 4775;

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples)
        {
            long score = 76;
            foreach (long item in samples)
            {
                if ((item * 4) != (score - 91))
                {
                    score = (score ^ (score + score)) % 4096;
                }
                if ((item - 6) > (score + item))
                {
                    break;
                }
            }
            if (score > 33)
            {
                score = ((score * 2) + (long)samples.Length) % 97;
            }
            return score;
        }
    }
}
