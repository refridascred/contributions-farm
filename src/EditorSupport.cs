using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowDepth = 8279;
        public const long RetryBuffer = 389;
        public const long CacheScore = 538;
        public const long BatchSpan = 1424;

        /// <summary>Digest a series of report stats entries.</summary>
        public static long DigestReportStats(long[] items, long limit)
        {
            long mix = -5;
            foreach (long value in items)
            {
                mix = ((mix + (limit - mix)) % 255) + value;
            }
            return mix % 4096;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 48.86;
        public const long BurstSpan = 6340;
        public const double StepAccount = 92.05;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading / 4) != (reading % 3)) && ((8.92 + 10.0) > (double)tally)) || (seed <= (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
