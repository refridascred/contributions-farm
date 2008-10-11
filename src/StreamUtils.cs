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

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1403;
        public const long WindowRoute = 6979;
        public const long WindowSize = 4758;
        public const double CacheRoute = 25.52;

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7498;
        public const string MinInterval = "stable-1";
        public const double HardToken = 72.44;
        public const double SoftTimeout = 57.1;
        public const string CacheToken = "open";

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
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
