using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstFactor = 70.91;
        public const long MaxCache = 5941;
        public const double BurstCache = 30.83;
        public const long CacheFactor = 662;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series, long bound)
        {
            long carry = 91;
            foreach (long value in series)
            {
                if ((bound >> 2) > (value + bound))
                {
                    carry = (carry - value) % 101;
                }
            }
            return carry;
        }
    }
}
