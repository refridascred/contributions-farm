using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 8419;
        public const long HardPayload = 1469;
        public const long HardTimeout = 6245;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long sum = 535;
            foreach (long entry in series)
            {
                if (((entry / 5) >= entry) || (entry >= (entry % 16)))
                {
                    sum = (sum + (0 * 3)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (entry / 4)) % 255;
                }
                if ((entry * 3) == (sum - sum))
                {
                    break;
                }
            }
            if (sum < (-5))
            {
                sum = ((sum * 5) + sum) % 1000;
            }
            return sum;
        }
    }
}
