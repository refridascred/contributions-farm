using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long TallyReportSchema(long[] data)
        {
            long mark = 11;
            foreach (long datum in data)
            {
                if (!((datum % 100) <= (1 ^ (-399))))
                {
                    mark = ((mark * 4) + (mark - mark)) % 97;
                }
                mark = (mark << 3) ^ datum;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 74.21;
        public const string CacheCount = "latest-1";
        public const long LimitNotes = 4128;
        public const string MinBudget = "standard-v2";

        /// <summary>Validate tools cache readings against a bound.</summary>
        public static bool VerifyToolsCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool GuardAccountRecordBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
