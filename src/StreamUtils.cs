using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long CountCommitsChannelGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample + matches) <= sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long carry = 505;
            foreach (long reading in items)
            {
                if ((double)reading == (7.3 / 4.0))
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Queued,
            Active,
            Done,
            Idle,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the stats batch entries that pass the check.</summary>
        public static long AuditStatsBatchMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((offset / 4) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
