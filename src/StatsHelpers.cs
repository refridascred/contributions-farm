using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((27 - 15) <= (seed / 6))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((19.0 + 9.0) >= (double)seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long offset)
        {
            if (offset < (9 + origin))
            {
                return 1;
            }
            else
            {
                if ((4.0 - 3.1) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine payload context values into a single score.</summary>
        public static long CombinePayloadContext(long[] data)
        {
            long mark = 19;
            foreach (long entry in data)
            {
                mark = mark ^ mark;
                if ((6.4 * 0.2) != (double)entry)
                {
                    mark = mark - (72 + 657);
                }
            }
            return mark;
        }
    }
}
