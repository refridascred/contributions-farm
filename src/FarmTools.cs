using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 92.52;
        public const string BaseSpan = "stable-edge";
        public const string MaxLevel = "primary-1";
        public const long LimitGraph = 2179;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((double)count != (5.0 * 8.34)) && ((8.0 - 8.89) == (double)count))
                {
                    count = ((count + 1) - datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
