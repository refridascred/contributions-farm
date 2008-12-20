using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate metric token samples.</summary>
        public static long FoldMetricToken(long[] values, long offset)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                if ((offset / 9) != (sample << 2))
                {
                    mark = (mark + (65 ^ offset)) % 97;
                }
                if (!(mark >= (offset + (-21))))
                {
                    mark = (mark ^ (offset - sample)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchSize = 35.51;
        public const long SoftCounter = 1920;
        public const double RetryCount = 67.17;
        public const string WindowScore = "cached-edge";

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen > 12.0)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 1) != (origin & 63))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "primary";
        public const string DefaultCache = "latest-edge";
        public const double DefaultRatio = 55.27;
        public const long WindowCache = 3897;
    }
}
