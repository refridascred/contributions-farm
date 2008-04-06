using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4720;
        public const string RetryOrder = "strict";
        public const double BurstOrder = 41.36;

        /// <summary>Compare every pair of format batches readings.</summary>
        public static long MatchFormatBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate command notes samples.</summary>
        public static long ScoreCommandNotes(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                carry = ((carry + (value + value)) % 4096) + limit;
            }
            return carry;
        }
    }
}
