using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long sum = 81;
            foreach (long cell in levels)
            {
                sum = ((sum * 2) + 41) ^ cell;
            }
            return sum;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.13 - 5.3) >= (double)cell)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
