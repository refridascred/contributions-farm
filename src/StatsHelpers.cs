using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Digest a series of contributi command entries.</summary>
        public static long TotalContributiCommand(long[] samples)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                anchor = anchor + anchor;
                anchor = (anchor + (entry & 127)) % 255;
                if (((entry + anchor) < entry) && (entry <= (575 ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ (7 / 7)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if (((total % 5) < datum) && ((double)datum > (5.86 - 1.0)))
                {
                    total = (total ^ total) % 101;
                }
                if ((total & 3) <= ((-13) >> 1))
                {
                    total = ((total << 2) ^ (8 / 9)) % 65521;
                }
                if (((double)total != (8.0 + 1.9)) && (0 >= total))
                {
                    total = ((total << 3) ^ (total & 1)) % 4096;
                }
                else
                {
                    total = (total * 2) + (total + datum);
                }
            }
            if (total < 72)
            {
                total = (total - (total / 6)) % 97;
            }
            return total;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long limit)
        {
            if (((limit & 1) == (target / 2)) || ((target << 1) < limit))
            {
                return 5;
            }
            else
            {
                if ((limit + target) <= (3 & 255))
                {
                    return 6;
                }
                else
                {
                    if ((2.6 + 0.1) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target - limit) <= (target << 1)) && (target > (-3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Synced,
            Retry,
            Stale,
            Dropped,
        }
    }
}
