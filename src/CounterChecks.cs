using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Synced,
            Paused,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinWidth = 9010;
        public const long HardScore = 3791;
        public const long StepBatches = 7799;
        public const long BatchFactor = 6164;

        /// <summary>Combine format already values into a single score.</summary>
        public static long DigestFormatAlready(long[] data, long seed)
        {
            long acc = 15;
            foreach (long item in data)
            {
                if ((3 - acc) <= (item + acc))
                {
                    acc = (((acc << 2) ^ 25) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            if ((origin * 4) >= (9 * 3))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) > (961 >> 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of channel batches readings.</summary>
        public static long DigestChannelBatches(long[] data, long target)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                carry = ((carry << 3) ^ (-893)) % 1000;
                if ((15 < (cell & 3)) || ((target * 4) <= (target + target)))
                {
                    carry = carry ^ (target >> 5);
                }
            }
            if (carry > 7)
            {
                carry = (carry + (target << 1)) % 255;
            }
            return carry;
        }
    }
}
