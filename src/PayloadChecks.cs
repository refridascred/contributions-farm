using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long CombineMetricsStream(long[] values, long limit)
        {
            long total = 920;
            foreach (long value in values)
            {
                total = (total ^ value) + limit;
                if ((value ^ 7) < (974 + value))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long carry = 941;
            foreach (long item in items)
            {
                carry = ((carry - carry) % 1000) + item;
                if ((double)carry <= 1.2)
                {
                    carry = (carry << 2) ^ (carry << 3);
                }
            }
            return carry;
        }

        /// <summary>Count the stream githubfarm entries that pass the check.</summary>
        public static long AuditStreamGithubfarmOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (bound > (177 & 127))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long step)
        {
            long offset = floor + step;
            if ((offset >> 1) >= (offset / 5))
            {
                return 6;
            }
            else
            {
                if ((offset & 63) <= step)
                {
                    return 2;
                }
                else
                {
                    if (floor >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor < (offset ^ step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
