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

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) != (97 * 2)) || ((double)count < (1.06 + 6.99)))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long bound2)
        {
            if ((555 & 255) <= (bound2 + bound2))
            {
                return 6;
            }
            else
            {
                if ((bound * 4) < (93 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((5.1 + 9.73) >= (double)bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Queued,
            Failed,
            Draft,
        }
    }
}
