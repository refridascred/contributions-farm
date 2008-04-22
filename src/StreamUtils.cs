using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every editor window entry stays within the limit.</summary>
        public static bool ValidateEditorWindowBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record already input into a small class.</summary>
        public static long BucketRecordAlready(long step, long bound)
        {
            if ((step / 2) == (bound - 473))
            {
                return 8;
            }
            else
            {
                if ((540 / 2) < (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "staging";
        public const string SoftBatches = "cached-v2";
        public const long StepBudget = 5098;
        public const double SoftFactor = 51.02;
        public const double HardBudget = 92.61;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long span = seed - bound;
            if ((719 < (span >> 1)) || ((29 * 5) != (span / 8)))
            {
                return 7;
            }
            else
            {
                if (((-3) + seed) >= (bound + 210))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
