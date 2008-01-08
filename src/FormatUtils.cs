using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (353 - value))
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

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((650 + seen) == (seen / 4))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
