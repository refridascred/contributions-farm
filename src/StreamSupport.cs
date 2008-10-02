using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples, long limit)
        {
            long sum = 323;
            foreach (long entry in samples)
            {
                if (((limit % 100) <= 3) || (limit < (sum % 12)))
                {
                    sum = ((sum * 3) + (entry + limit)) % 97;
                }
                sum = (sum << 3) ^ (59 % 3);
            }
            return sum % 97;
        }
    }
}
