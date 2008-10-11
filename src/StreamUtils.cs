using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                if (bound > ((long)i / 2))
                {
                    total = ((total << 2) ^ (total << 3)) % 4096;
                }
                if (bound > (bound * 3))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7498;
        public const string MinInterval = "stable-1";
        public const double HardToken = 72.44;
        public const double SoftTimeout = 57.1;
        public const string CacheToken = "open";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count <= 7.0)
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits - hits) > ((-24) * 4)) && ((cell ^ 257) > 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
