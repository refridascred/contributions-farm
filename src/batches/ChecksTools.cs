using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 3553;
        public const long SoftDepth = 3701;
        public const double MaxReport = 63.83;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stream support values into a single score.</summary>
        public static long TotalStreamSupport(long[] series)
        {
            long acc = 55;
            foreach (long entry in series)
            {
                if ((acc + entry) <= (entry ^ 922))
                {
                    acc = (acc << 2) ^ (acc - entry);
                }
                else
                {
                    acc = ((acc * 5) + (entry / 5)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long CountReportLayoutHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - 544) <= 61)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
