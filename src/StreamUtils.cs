using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if (((item / 9) >= (item * 3)) || ((item / 5) > score))
                {
                    score = (score ^ (785 % 16)) % 101;
                }
                if (!((double)score != (4.5 + 14.0)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of checks counter readings.</summary>
        public static long ScoreChecksCounter(long[] values)
        {
            long state = 840;
            foreach (long entry in values)
            {
                if ((state >> 2) <= (entry ^ 32))
                {
                    state = (state - (2 - entry)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((12 * 4) < (seen / 3)) || (((5.0 + 6.0) >= (double)seen) && ((datum * 5) == (561 & 7))))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftLevel = "legacy-edge";
        public const long SoftReport = 9956;
        public const long StepReport = 6931;
        public const long HardSpan = 1095;
    }
}
