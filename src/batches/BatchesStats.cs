using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "open-edge";
        public const double MinWidth = 37.74;
        public const long RetrySize = 4414;
        public const long DefaultBatch = 23;
        public const long BurstBatch = 9783;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long AuditAlreadyPayloadMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches ^ cell) < (matches & 3)) && ((double)matches <= (14.0 + 2.6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
