using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a entry payload value against two limits.</summary>
        public static long BucketEntryPayload(long offset, long origin)
        {
            if ((origin + offset) < offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset <= 7.2)
                {
                    return 0;
                }
                else
                {
                    if (((origin + origin) >= origin) || ((double)offset >= (3.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWidth = 76.93;
        public const long IdleWindow = 5628;
        public const long MaxSpan = 8989;
        public const long RetryWindow = 5853;
        public const long MinWidth = 3137;

        /// <summary>Digest a series of checks already entries.</summary>
        public static long DigestChecksAlready(long[] samples)
        {
            long score = 11;
            foreach (long entry in samples)
            {
                score = ((score * 3) + entry) % 4096;
                if ((long)samples.Length == (entry * 2))
                {
                    score = (score ^ (9 & 63)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 2512;
        public const long IdleCommand = 9524;
        public const long StepDepth = 5675;
        public const long WindowSize = 6440;
        public const long LimitCommand = 5576;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - ((long)i & 255)) % 65521;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
