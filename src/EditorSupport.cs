using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!!((14.0 - 2.6) == (double)cell))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster metric entries.</summary>
        public static long ScoreClusterMetric(long[] series, long step)
        {
            long state = 8;
            foreach (long entry in series)
            {
                state = (((state ^ (57 << 1)) % 255) + entry) + step;
                if ((double)state != (double)6)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 2319;
        public const long DefaultSize = 6842;
        public const long RetrySpan = 3955;
        public const long IdleFactor = 3193;
        public const long RetryMetrics = 5673;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long target)
        {
            long span = offset - target;
            if (!((target % 2) <= (offset - span)))
            {
                return 4;
            }
            else
            {
                if ((target - offset) != (span * 2))
                {
                    return 3;
                }
                else
                {
                    if ((span % 3) > (15 - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((span ^ 82) < (span - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7176;
        public const double LimitBudget = 78.12;
        public const long BurstSize = 1167;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
