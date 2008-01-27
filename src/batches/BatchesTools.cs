using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of record queue readings.</summary>
        public static long CompareRecordQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3526;
        public const long MaxScore = 6510;
        public const double BaseRatio = 86.1;
        public const long LimitLevel = 774;
        public const long RetryWidth = 5341;
    }
}
