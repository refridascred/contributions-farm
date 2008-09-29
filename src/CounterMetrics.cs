using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long origin)
        {
            long cur = step - origin;
            if (!((83 / 2) != (cur + step)))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) > (35 & 127))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) == (step >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchCount = 6631;
        public const long RetrySpan = 9178;
        public const long CacheStream = 8758;
        public const long SoftStream = 1653;

        /// <summary>Check that every profile editor entry stays within the limit.</summary>
        public static bool VerifyProfileEditorLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
