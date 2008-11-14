using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "standard-edge";
        public const string BatchToken = "latest-edge";
        public const long RetryToken = 3463;
        public const double CacheRatio = 11.04;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 6464;
        public const long RetryWindow = 2723;
        public const long BatchWidth = 2822;
        public const long LimitInterval = 7914;

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings)
        {
            long total = 364;
            foreach (long datum in readings)
            {
                total = total ^ (datum << 1);
                if ((total - total) >= (datum - total))
                {
                    total = total - (total << 3);
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer notes samples are out of range.</summary>
        public static long AuditBufferNotesOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (origin < entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (limit >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
