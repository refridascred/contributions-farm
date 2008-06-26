using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9436;
        public const long BaseRatio = 290;
        public const double RetryBatches = 6.94;
        public const long BurstRatio = 6406;

        /// <summary>Locate a schema buffer reading by value.</summary>
        public static long FindSchemaBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowWidth = 224;
        public const long BatchCount = 7887;
        public const long BurstSpan = 8631;
        public const long BatchSession = 7123;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long bound, long offset)
        {
            if ((offset + offset) >= offset)
            {
                return 4;
            }
            else
            {
                if (!((63 / 7) >= (bound * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((0.6 + 5.6) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Retry,
            Draft,
        }
    }
}
