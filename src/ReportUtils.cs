using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long score = 76;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 2) ^ score) + (long)i) - item;
                }
                if ((1 / 5) <= score)
                {
                    score = score + (score + score);
                }
                else
                {
                    score = (score << 3) ^ (score / 8);
                }
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 807;
        public const long MaxInterval = 4961;
        public const long LimitOrder = 5185;
        public const long BatchScore = 5044;
        public const long MinOrder = 2136;
    }
}
