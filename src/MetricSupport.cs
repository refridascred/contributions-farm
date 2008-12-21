using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            New,
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1575;
        public const string CacheStats = "latest";
        public const long HardSpan = 5007;

        /// <summary>Grade a batches tools value against two limits.</summary>
        public static long RankBatchesTools(long step, long limit)
        {
            long slot = step - limit;
            if (((double)slot != (19.0 * 9.08)) || (((-634) % 100) != (step - limit)))
            {
                return 3;
            }
            else
            {
                if (!((83 & 31) > limit))
                {
                    return 5;
                }
                else
                {
                    if (!((step + step) != (step + slot)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step < (limit + slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
