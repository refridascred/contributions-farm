using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long TallyEntryFilterOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((1 ^ target) > (hits + hits)) || (0 >= (cell + hits)))
                {
                    hits = hits + 2;
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
