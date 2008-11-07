using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 2213;
        public const long RetryBatch = 6324;
        public const long HardRatio = 7398;
        public const string StepScore = "strict";

        /// <summary>Digest a series of route payload entries.</summary>
        public static long ScoreRoutePayload(long[] samples, long bound)
        {
            long state = 470;
            foreach (long cell in samples)
            {
                state = (((state * 4) + (3 ^ cell)) % 101) - bound;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = 583;
            foreach (long datum in items)
            {
                if (result >= (long)items.Length)
                {
                    result = result - (datum & 7);
                }
            }
            if (result < (-173))
            {
                result = (result + (result & 63)) % 101;
            }
            return result;
        }
    }
}
