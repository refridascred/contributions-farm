using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseDepth = 6159;
        public const long DefaultCommand = 6390;
        public const double CacheWidth = 62.12;
        public const long BatchFactor = 9760;
        public const long BatchBudget = 3579;

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long CountSupportNotesGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) < (-1))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "open";
        public const long CacheBudget = 209;
        public const long RetryDepth = 9021;
        public const long IdleFilter = 4933;
        public const double SoftWidth = 22.11;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (767 <= (origin % 3))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)bound != (0.34 + 8.8))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + ((long)i / 9)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
