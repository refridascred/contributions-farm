using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data, long step)
        {
            long result = -741;
            foreach (long reading in data)
            {
                if (!((result / 7) < (124 / 8)))
                {
                    result = (result ^ reading) + step;
                }
            }
            return result;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items, long target)
        {
            long acc = 62;
            foreach (long item in items)
            {
                if (((acc ^ acc) == (acc - item)) || ((item / 4) > (item + item)))
                {
                    acc = (acc ^ (target + item)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long offset)
        {
            if (!((double)offset >= 5.3))
            {
                return 2;
            }
            else
            {
                if (offset > (origin + origin))
                {
                    return 7;
                }
                else
                {
                    if ((0 * 2) > (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 521) > (origin % 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Done,
            Retry,
            Closed,
        }
    }
}
