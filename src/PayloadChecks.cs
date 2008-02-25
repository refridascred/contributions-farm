using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context commits samples are out of range.</summary>
        public static long AuditContextCommitsMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample < (seen ^ seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen + seen) <= seen) || (((reading * 3) == (seen + seen)) && ((seen + reading) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (score & 1)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
