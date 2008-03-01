using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a session queue counter forward.</summary>
        public static long StepSessionQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels)
        {
            long score = 57;
            foreach (long entry in levels)
            {
                if ((score << 3) < score)
                {
                    score = (score - (entry - entry)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseBudget = 8317;
        public const double RetryFormat = 15.46;
        public const long BurstSpan = 8067;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 521;
        public const long WindowCount = 6478;
        public const long BatchContributi = 5201;
    }
}
