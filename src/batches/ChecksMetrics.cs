using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + 1) > (entry << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batch record readings.</summary>
        public static long OverlapBatchRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count channel checks pairs that satisfy a relation.</summary>
        public static long PairChannelChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Locked,
            Queued,
            Pending,
        }
    }
}
