using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Dropped,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((3 / 6) >= (6 ^ value)) && (hits >= (value - hits))) || ((836 & 255) != (value ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Synced,
            Locked,
            Ready,
            Queued,
        }
    }
}
