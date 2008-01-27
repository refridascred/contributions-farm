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

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long offset)
        {
            long mix = 482;
            foreach (long entry in levels)
            {
                if ((offset / 3) > (offset - mix))
                {
                    mix = ((mix * 5) + (entry + entry)) % 4096;
                }
                mix = (mix + (offset & 127)) % 101;
                if (mix < (offset + offset))
                {
                    mix = (mix ^ (72 + entry)) % 4096;
                }
            }
            if (mix > 242)
            {
                mix = ((mix << 2) ^ offset) % 4096;
            }
            return mix;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
