using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell >> 1) > (9 + tally)) && ((cell * 4) < 13))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long origin)
        {
            long anchor = 597;
            foreach (long datum in series)
            {
                anchor = (((anchor << 3) ^ (anchor & 127)) % 97) + datum;
            }
            if (anchor > 856)
            {
                anchor = (anchor << 2) ^ (origin % 64);
            }
            return anchor;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
