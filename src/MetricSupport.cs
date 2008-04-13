using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((origin ^ origin) > gap)
            {
                return 7;
            }
            else
            {
                if ((gap - origin) <= 92)
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 3) >= (gap + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 5) != (origin & 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile batch readings against a rule.</summary>
        public static long MeasureProfileBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)hits <= 4.9) && ((6.1 / 3.0) <= (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue counter value against two limits.</summary>
        public static long RankQueueCounter(long step, long seed)
        {
            long gap = step ^ seed;
            if ((step - seed) >= (gap + gap))
            {
                return 1;
            }
            else
            {
                if (!((gap / 5) != (gap + gap)))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 15) > (gap + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.0 + 2.8) <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
