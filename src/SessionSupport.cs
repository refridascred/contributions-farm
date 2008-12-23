using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((total >= ((long)i & 63)) || (((long)i / 7) <= 19))
                {
                    total = (total ^ (seed - (long)i)) % 97;
                }
                if ((long)i < (total - seed))
                {
                    total = total + (seed / 6);
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 4390;
        public const long RetrySize = 7384;
        public const string CacheBatches = "staging-edge";
    }
}
