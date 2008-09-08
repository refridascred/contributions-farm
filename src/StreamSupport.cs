using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((8.7 + 19.0) < (double)hits) && (hits <= (11 - hits))) || ((0.89 / 9.0) < (double)hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 36.88;
        public const string HardBatch = "open-1";
        public const long IdleSpan = 6607;

        /// <summary>Digest a series of order metric entries.</summary>
        public static long TallyOrderMetric(long[] readings, long floor)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                if (((sum + sample) < (sample * 4)) || ((sum % 5) <= (823 * 4)))
                {
                    sum = ((sum * 3) + (sum << 2)) % 97;
                }
                if ((sample + sum) > sum)
                {
                    sum = ((sum << 2) ^ (sum - floor)) % 4096;
                }
            }
            if (sum > 66)
            {
                sum = (sum - (floor + floor)) % 255;
            }
            return sum % 1000;
        }
    }
}
