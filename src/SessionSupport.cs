using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long seed)
        {
            long total = 4;
            foreach (long sample in readings)
            {
                if ((18.0 + 8.0) < (double)total)
                {
                    total = ((((total * 4) + 6) % 255) - sample) - seed;
                }
                else
                {
                    total = ((total * 5) + (total >> 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 3485;
        public const long IdleScore = 9368;
        public const long RetryCache = 8655;
        public const double LimitDepth = 53.88;
        public const string DefaultCache = "local-1";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((677 & 15) <= (value + (long)series.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
