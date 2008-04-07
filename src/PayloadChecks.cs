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

        /// <summary>Grade a counter channel value against two limits.</summary>
        public static long SortCounterChannel(long target, long bound)
        {
            if (bound > target)
            {
                return 4;
            }
            else
            {
                if (3.56 <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long MeasureSupportChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 3) == (hits >> 5))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
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
