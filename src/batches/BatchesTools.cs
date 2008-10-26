using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 7837;
        public const long BaseSupport = 8254;
        public const long BatchSupport = 8744;
        public const string LimitScore = "staging-edge";
        public const long CacheSupport = 913;

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mark = 77;
            foreach (long reading in readings)
            {
                mark = (mark - (mark + mark)) ^ reading;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
