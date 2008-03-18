using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples, long step)
        {
            long sum = 70;
            foreach (long sample in samples)
            {
                if ((360 ^ 80) > (step - step))
                {
                    sum = ((sum << 3) ^ (sample + sum)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 656;
        public const string WindowSpan = "legacy-v2";
        public const long IdleRatio = 5642;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (867 < (hits + (long)samples.Length))
                {
                    hits = ((hits + 2) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
