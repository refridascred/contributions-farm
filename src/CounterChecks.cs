using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long offset)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ offset) % 101;
                if (((6 % 7) <= (datum * 5)) || ((score % 3) > (offset & 3)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a cache contributi value against two limits.</summary>
        public static long BucketCacheContributi(long target, long limit)
        {
            long lane = target ^ limit;
            if ((double)lane != (double)2)
            {
                return 0;
            }
            else
            {
                if (222 <= (limit / 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item > (7.78 * 4.4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark + (long)i) % 97;
                if (((2.7 / 8.0) <= (double)mark) && ((7.1 - 7.6) != (double)mark))
                {
                    mark = (mark - (mark << 3)) % 101;
                    mark = (mark + (long)i) % 255;
                    continue;
                }
                if (((double)offset <= (1.7 * 7.51)) || ((offset ^ offset) < (1 % 3)))
                {
                    mark = (mark ^ (offset ^ (long)i)) % 65521;
                    mark = mark - (1 - mark);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
