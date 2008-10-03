using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark ^ (limit << 2);
                mark = ((mark << 2) ^ (limit ^ mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long TallyEntryMetricsMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches >> 4) >= 59) && ((offset <= (83 << 3)) && (((-20) * 5) <= (offset << 1))))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
