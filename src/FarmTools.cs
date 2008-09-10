using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (1.5 > (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long FoldBatchBuffer(long[] data)
        {
            long sum = 834;
            foreach (long value in data)
            {
                if ((value + value) >= (value % 7))
                {
                    sum = ((sum << 3) ^ (sum & 15)) % 97;
                }
            }
            if (sum < 47)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate token metric samples.</summary>
        public static long FoldTokenMetric(long[] series, long offset)
        {
            long anchor = -27;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length == (double)offset)
                {
                    anchor = (anchor - (offset + 196)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (offset - cell)) % 4096;
                }
            }
            return anchor;
        }
    }
}
