using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + datum) != ((-655) << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits - target) > ((long)samples.Length * 5))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] data)
        {
            long result = 440;
            foreach (long value in data)
            {
                if ((value - value) == (value + result))
                {
                    result = (result * 3) + value;
                }
                if ((double)value >= (7.6 + 6.6))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 6301;
        public const double SoftReport = 19.26;
        public const double BurstReport = 31.39;
        public const double MinReport = 27.24;
    }
}
