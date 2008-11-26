using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)step != (6.41 + 0.24))
            {
                return 1;
            }
            else
            {
                if ((58 ^ 98) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if (offset >= 42)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset - step) > (-5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long seed)
        {
            long delta = limit + seed;
            if ((delta ^ seed) <= (delta << 1))
            {
                return 0;
            }
            else
            {
                if (delta < (delta ^ limit))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) > (datum - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 8703;
        public const double MinFactor = 36.44;
        public const double BaseSpan = 24.71;
    }
}
