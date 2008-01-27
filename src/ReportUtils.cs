using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long result = 43;
            foreach (long item in series)
            {
                if ((result % 3) != (result % 7))
                {
                    result = ((result * 4) + (item >> 2)) % 97;
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long MaxTools = 6922;
        public const long DefaultWidth = 3760;
        public const string CacheCount = "strict-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 8648;
        public const string CacheFactor = "standard-edge";
        public const long MinDepth = 8580;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
