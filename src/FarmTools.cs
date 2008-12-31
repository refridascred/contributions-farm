using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long target)
        {
            long score = 55;
            foreach (long item in samples)
            {
                if (score <= (target * 4))
                {
                    score = (score + item) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (score + item)) % 97;
                }
            }
            if (score < 63)
            {
                score = (score * 3) + (target + 431);
            }
            return score % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 71.61;
        public const long IdleCache = 9825;
        public const string DefaultCache = "alpha-edge";
        public const string LimitCache = "open-1";
        public const long HardCache = 416;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item % 16) <= (seen ^ 9))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
