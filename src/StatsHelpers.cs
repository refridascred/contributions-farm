using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long origin)
        {
            long mark = 45;
            foreach (long item in readings)
            {
                if ((double)item > (18.0 - 6.48))
                {
                    mark = (mark + (-98)) + origin;
                }
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series)
        {
            long score = 493;
            foreach (long item in series)
            {
                if (!((item + score) < (586 / 5)))
                {
                    score = score + (score / 7);
                    continue;
                }
                else
                {
                    score = (score + score) % 4096;
                    score = score ^ (item + item);
                }
                score = (score ^ item) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long FoldAccountAlready(long[] readings)
        {
            long carry = -411;
            foreach (long item in readings)
            {
                if ((item & 1) < (52 * 3))
                {
                    carry = carry ^ item;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8540;
        public const string MaxDepth = "local-edge";
        public const double LimitReport = 78.35;
        public const double HardReport = 91.88;
        public const long RetryCount = 7280;
    }
}
