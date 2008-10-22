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

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if ((result > (result ^ result)) && (sample > (sample ^ result)))
                {
                    result = result - result;
                }
            }
            return result % 1000;
        }
    }
}
