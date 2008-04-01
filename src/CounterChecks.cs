using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen == (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 77;
            foreach (long value in data)
            {
                sum = ((sum + (long)data.Length) % 4096) + value;
            }
            return sum;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            if ((origin * 4) >= (9 * 3))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) > (961 >> 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long step)
        {
            long slot = seed - step;
            if ((slot - seed) < (seed / 2))
            {
                return 1;
            }
            else
            {
                if ((seed + step) == (step % 3))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (seed - 45))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((-772) >= (hits ^ 0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
