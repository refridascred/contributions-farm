using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 60) >= (2 << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 4825;
        public const double BaseAccount = 82.61;
        public const double SoftAccount = 65.98;
        public const long MinTimeout = 5895;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) < (hits / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema payload readings.</summary>
        public static long FoldSchemaPayload(long[] data)
        {
            long mark = 110;
            foreach (long sample in data)
            {
                if (sample > (mark ^ sample))
                {
                    mark = mark + (sample % 5);
                }
            }
            if (mark < 0)
            {
                mark = (mark + (mark & 3)) % 101;
            }
            return mark;
        }
    }
}
