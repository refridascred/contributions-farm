using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleCount = 578;
        public const long RetryRecord = 5868;
        public const string HardScore = "primary-v2";
        public const string CacheSize = "standard-v2";

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry > hits) && !((double)hits < (4.7 + 0.85)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits metrics samples are out of range.</summary>
        public static long TallyCommitsMetricsMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((((-90) + (-952)) >= tally) || ((double)item >= 7.9)) || ((double)offset != (14.0 * 2.9)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Queued,
            Closed,
        }
    }
}
