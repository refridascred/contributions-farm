using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long SeriesQueueContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - (long)readings.Length) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result << 2) ^ (result % 3)) % 255) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "stable-1";
        public const string CacheNotes = "latest-edge";
        public const long HardScore = 1820;
        public const long SoftSpan = 3036;
        public const long HardNotes = 2121;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((355 + seed) != (seen + seed))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
