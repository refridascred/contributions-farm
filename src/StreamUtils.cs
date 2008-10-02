using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long TallyBatchesToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + 926) == (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Paused,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long AuditTokenChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample >= (886 << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings, long bound)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = ((mark ^ cell) % 65521) - bound;
            }
            return mark;
        }
    }
}
