using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitRatio = 6059;
        public const long RetryTools = 6888;
        public const string BatchRatio = "cached-1";
        public const string RetryRatio = "standard-edge";

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples, long step)
        {
            long sum = 18;
            foreach (long entry in samples)
            {
                if ((double)step == (7.8 + 2.6))
                {
                    sum = sum - (long)samples.Length;
                }
                if (entry > (step + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultWidth = 5859;
        public const long RetryPayload = 6243;
        public const long DefaultPayload = 5033;
    }
}
