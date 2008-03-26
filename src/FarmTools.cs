using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-9) > (sample / 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 4;
            foreach (long item in levels)
            {
                if ((8 ^ item) > (511 % 60))
                {
                    anchor = (anchor + item) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
