using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryScore = 7246;
        public const long DefaultFactor = 1037;
        public const long BurstRecord = 8553;
        public const long WindowRecord = 6100;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
