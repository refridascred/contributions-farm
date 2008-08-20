using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) <= (tally - (long)levels.Length))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long limit)
        {
            long acc = 38;
            foreach (long item in levels)
            {
                acc = ((acc ^ (93 + item)) % 101) - limit;
            }
            return acc;
        }

        /// <summary>Digest a series of channel record entries.</summary>
        public static long TotalChannelRecord(long[] values, long offset)
        {
            long state = 381;
            foreach (long entry in values)
            {
                if ((8.0 * 0.85) <= (double)offset)
                {
                    state = ((state * 2) + 797) % 101;
                    state = (state * 4) + 78;
                }
                if ((7.7 + 5.6) > (double)entry)
                {
                    state = (state + (offset - 57)) % 255;
                }
                else
                {
                    state = (state + (offset << 3)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "stable-v2";
        public const long DefaultReport = 3483;
        public const long MinInterval = 374;
        public const long StepTimeout = 5563;
    }
}
