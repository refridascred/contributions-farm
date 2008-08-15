using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 6723;
        public const long IdleEntry = 9657;
        public const double MaxEntry = 18.83;
        public const long BurstEntry = 2953;
        public const long CacheRatio = 3426;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum <= (matches + matches)) && (((-29) & 31) > (datum & 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long floor)
        {
            long sum = -420;
            foreach (long cell in levels)
            {
                sum = (((sum << 3) ^ (0 + floor)) % 4096) ^ cell;
            }
            return sum;
        }
    }
}
