using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long MeasureFilterAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count % 3) <= (entry ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((floor <= (matches + floor)) && (0.4 < (double)cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}
