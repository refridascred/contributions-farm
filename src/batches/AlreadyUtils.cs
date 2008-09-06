using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length > (tally - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstScore = 6958;
        public const double CacheOrder = 74.9;
        public const string DefaultOrder = "staging-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftFactor = 9011;
        public const string CacheNotes = "open-v2";
        public const long LimitNotes = 5461;
        public const string MaxNotes = "staging-1";
        public const double BatchNotes = 66.15;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
