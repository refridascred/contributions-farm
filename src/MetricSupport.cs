using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long step2)
        {
            long gap = step + step2;
            if (gap <= (902 ^ step))
            {
                return 7;
            }
            else
            {
                if ((step + gap) > 94)
                {
                    return 2;
                }
                else
                {
                    if ((step2 - step) < step2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
