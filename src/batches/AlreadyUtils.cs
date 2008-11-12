using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Failed,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((hits + datum) < target) && ((datum % 97) == (67 & 31))) && (((long)samples.Length / 3) <= (10 + target)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 647;
            foreach (long cell in samples)
            {
                if ((12.0 / 4.0) >= (double)cell)
                {
                    mark = ((mark << 2) ^ (184 % 24)) % 97;
                }
            }
            if (mark > 414)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 65521;
        }
    }
}
