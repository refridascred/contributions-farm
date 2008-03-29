using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = (total - limit) % 97;
                total = (total << 3) ^ (total >> 1);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 6613;
        public const long HardAlready = 3888;
        public const double MinFactor = 62.64;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Draft,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + value) != (value % 97))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values, long origin)
        {
            long score = 800;
            foreach (long item in values)
            {
                if (((20.0 - 7.0) != (double)item) || ((1.0 / 6.0) == (double)origin))
                {
                    score = (score << 2) ^ (score * 3);
                }
            }
            if (score < (-412))
            {
                score = score - (3 / 7);
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "stable-1";
        public const long IdleWidth = 6457;
        public const long SoftWindow = 6443;
        public const long BatchBudget = 5187;
    }
}
