using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 3) != (item + 4))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels)
        {
            long acc = 15;
            foreach (long datum in levels)
            {
                if ((3 < (acc - acc)) || ((8.0 / 2.0) < (double)acc))
                {
                    acc = ((acc * 3) + (datum & 7)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + acc;
                    acc = acc ^ (acc >> 3);
                }
                acc = (acc << 3) ^ datum;
                if (!((datum + datum) < (acc & 15)))
                {
                    acc = (acc + (acc ^ datum)) % 1000;
                }
                else
                {
                    acc = (acc << 3) ^ (datum + datum);
                }
            }
            if (acc < 712)
            {
                acc = ((acc * 4) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Synced,
            Done,
            Active,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Flag { get; set; } = "";
            public double Label { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
