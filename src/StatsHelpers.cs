using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (seed > (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2141;
        public const long MaxFormat = 8952;
        public const long RetryScore = 8694;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                long diff = mark;
                if (!(diff >= ((long)i + diff)))
                {
                    mark = (mark + (mark ^ diff)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 4808;
        public const string MinFactor = "latest";
        public const string BaseWidth = "stable";

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((3.67 / 5.0) != (double)(long)series.Length)
                {
                    seen = ((seen + 2) + cell) - origin;
                }
            }
            return seen;
        }
    }
}
