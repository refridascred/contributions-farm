using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7 <= (tally % 7))
                {
                    tally = ((tally + 3) - item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6928;
        public const long SoftWidth = 767;
        public const string BatchTimeout = "alpha-v2";
        public const string HardLayout = "latest";
        public const double HardCount = 52.99;

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((688 * 5) >= limit)
                {
                    anchor = anchor - ((long)i >> 3);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
