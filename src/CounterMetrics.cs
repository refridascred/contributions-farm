using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long offset)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                if ((807 ^ mark) >= (datum / 5))
                {
                    mark = mark ^ (mark % 10);
                }
                else
                {
                    mark = (mark * 3) + (offset * 4);
                }
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((value + value) > (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long origin, long target)
        {
            if (((4 % 100) < (target + target)) && (457 > (target % 3)))
            {
                return 3;
            }
            else
            {
                if (((target + 28) > (993 % 16)) || ((double)origin > (6.1 - 0.8)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >= 53) && ((origin >> 3) == (3 + target)))
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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Idle,
            New,
        }
    }
}
