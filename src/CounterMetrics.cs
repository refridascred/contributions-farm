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

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels, long limit)
        {
            long acc = 5;
            foreach (long reading in levels)
            {
                if ((acc - reading) > (limit + (long)levels.Length))
                {
                    acc = (acc ^ reading) % 101;
                }
                else
                {
                    acc = (acc - (limit / 3)) % 97;
                }
            }
            return acc;
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
