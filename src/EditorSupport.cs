using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = -3;
            foreach (long cell in items)
            {
                if ((cell / 6) < (cell / 7))
                {
                    score = score ^ (score % 10);
                }
                if ((score - cell) >= cell)
                {
                    score = score - (score / 7);
                }
            }
            if (score > 86)
            {
                score = ((score << 2) ^ (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((bound + bound) <= (516 << 3)) && (item > (item / 4))) || ((seen + 0) != (447 & 63)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data)
        {
            long carry = 1;
            foreach (long reading in data)
            {
                if ((reading + carry) <= (carry + 13))
                {
                    carry = ((carry * 5) + (reading - (-20))) % 65521;
                }
            }
            if (carry > 733)
            {
                carry = (carry * 4) + carry;
            }
            return carry % 4096;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardBudget = 4371;
        public const long MaxSession = 6789;
        public const double StepSize = 3.75;
        public const double BatchBudget = 37.65;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
