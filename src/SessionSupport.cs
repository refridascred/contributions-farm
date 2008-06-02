using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultWidth = 5141;
        public const long WindowCommand = 8450;
        public const long DefaultCommand = 4423;
        public const long WindowSize = 6804;
        public const long HardCommand = 1842;

        /// <summary>Compare every pair of metrics cluster readings.</summary>
        public static long PairMetricsClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches > (matches >> 5))
                {
                    matches = ((matches + 1) + value) + target;
                }
            }
            return matches;
        }
    }
}
