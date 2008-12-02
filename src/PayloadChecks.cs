using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Retry,
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + datum) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) < (seen << 3))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                mark = (mark - (mark + step)) ^ datum;
                mark = (mark ^ (mark << 2)) % 65521;
            }
            return mark;
        }
    }
}
