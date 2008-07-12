using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheTimeout = "strict-1";
        public const long WindowEditor = 8559;
        public const long SoftEditor = 6058;

        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long DigestBatchBuffer(long[] series)
        {
            long total = -61;
            foreach (long value in series)
            {
                if ((total & 255) == (value + total))
                {
                    total = (total + (value >> 2)) % 255;
                }
            }
            if (total > 830)
            {
                total = ((total << 3) ^ ((long)series.Length & 7)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches >= (matches - matches))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((carry - cell) <= (carry << 3))
                {
                    carry = (carry * 5) + (cell % 16);
                }
            }
            if (carry > 558)
            {
                carry = carry - (carry & 127);
            }
            return carry;
        }
    }
}
