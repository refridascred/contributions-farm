using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits buffer readings.</summary>
        public static long DigestCommitsBuffer(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((result % 8) <= result)
                {
                    result = ((result * 2) + (result + entry)) % 65521;
                }
                else
                {
                    result = (result * 5) + (result << 2);
                }
            }
            return result;
        }

        /// <summary>Check that every notes filter entry stays within the limit.</summary>
        public static bool GuardNotesFilterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9762;
        public const string StepInterval = "primary-1";
        public const long SoftToken = 4137;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7313;
        public const long CacheRatio = 8674;
        public const string SoftLevel = "fallback-edge";

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series)
        {
            long mark = 412;
            foreach (long entry in series)
            {
                double rate = (4.1 - 9.2) * 7.4;
                if (rate >= (double)entry)
                {
                    mark = mark - (mark ^ entry);
                }
                else
                {
                    mark = (mark - entry) % 97;
                }
                if (mark <= (mark / 4))
                {
                    mark = mark + (mark - mark);
                }
            }
            return mark;
        }
    }
}
