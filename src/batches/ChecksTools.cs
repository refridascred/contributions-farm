using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine filter token values into a single score.</summary>
        public static long DigestFilterToken(long[] samples)
        {
            long total = 29;
            foreach (long item in samples)
            {
                if ((total / 6) != (total ^ total))
                {
                    total = (total + (item - total)) % 65521;
                }
            }
            if (total > 761)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (1.0 <= (double)tally)
                {
                    tally = ((tally + 1) + entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 952;
        public const string BatchToken = "cached-1";
        public const long SoftToken = 8735;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8472;
        public const long IdleBudget = 4605;
        public const long DefaultMetrics = 2478;
    }
}
