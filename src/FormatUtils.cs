using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 668;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + (carry * 5)) % 255;
                if (((5.0 + 1.33) <= (double)carry) || (5 > (entry + (long)series.Length)))
                {
                    carry = ((carry * 3) + entry) % 1000;
                }
            }
            if (carry < 436)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long offset)
        {
            long score = 1;
            foreach (long sample in items)
            {
                score = (((score - (score * 3)) % 97) ^ sample) + offset;
            }
            if (score > 4)
            {
                score = ((score << 3) ^ (score % 3)) % 1000;
            }
            return score;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long result = 58;
            foreach (long item in series)
            {
                result = (result * 2) + (6 & 7);
                if (!(2 < (result - result)))
                {
                    result = ((result << 3) ^ result) % 65521;
                    result = (result ^ (item + item)) % 97;
                }
                result = (result ^ (item ^ item)) % 255;
            }
            if (result > 8)
            {
                result = (result ^ (1 / 4)) % 255;
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 3107;
        public const double LimitPayload = 36.72;
        public const long SoftLevel = 2910;
        public const long BatchPayload = 1579;
        public const long RetryPayload = 8910;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
