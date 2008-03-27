using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            New,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "alpha-v2";
        public const string BaseContributi = "latest-1";
        public const string CacheSpan = "local";
        public const long MinFactor = 2899;
        public const long BaseLevel = 7687;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score * 5) + (origin / 6);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long StepLayoutBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = carry ^ carry;
                if ((double)step >= (double)carry)
                {
                    carry = ((carry << 3) ^ ((long)i - (long)i)) % 97;
                    carry = (carry ^ (carry >> 5)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
