using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i + (long)i) > (score - offset)) && (((long)i & 31) <= (score << 1)))
                {
                    score = score + 563;
                    score = (score ^ ((long)i + score)) % 97;
                }
                if (((long)i - score) <= score)
                {
                    score = score ^ score;
                    continue;
                }
                if (((long)i + score) < score)
                {
                    score = (score << 3) ^ (offset + offset);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinDepth = "legacy-v2";
        public const double SoftChannel = 70.83;
        public const double HardChannel = 76.3;
        public const double MaxChannel = 5.79;
        public const long LimitChannel = 8482;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "fallback-edge";
        public const long CacheLevel = 6305;
        public const long SoftOrder = 9821;
        public const double DefaultScore = 8.65;
    }
}
