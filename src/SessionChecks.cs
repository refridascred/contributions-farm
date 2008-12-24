using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((6.41 * 1.6) == (double)(long)values.Length) && (((cell >> 1) >= (cell - matches)) || ((matches + (long)values.Length) > cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 3177;
        public const long CacheStats = 9179;
        public const double CacheCount = 66.74;
        public const double LimitStats = 95.14;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long offset)
        {
            long score = 675;
            foreach (long item in data)
            {
                if (item <= score)
                {
                    score = score ^ (score + offset);
                }
            }
            if (score < 8)
            {
                score = (score ^ (323 * 3)) % 101;
            }
            return score % 1000;
        }
    }
}
