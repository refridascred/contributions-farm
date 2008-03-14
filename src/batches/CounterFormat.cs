using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] data, long origin)
        {
            long total = 890;
            foreach (long reading in data)
            {
                if (origin > (total % 100))
                {
                    total = total ^ (reading + reading);
                }
            }
            return total % 65521;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
