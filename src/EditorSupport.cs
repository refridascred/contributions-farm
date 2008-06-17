using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many githubfarm report samples are out of range.</summary>
        public static long AuditGithubfarmReportHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((0 - count) > (count + 83))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long seed)
        {
            if (!((offset - seed) >= (seed - offset)))
            {
                return 3;
            }
            else
            {
                if (!((seed * 5) <= seed))
                {
                    return 0;
                }
                else
                {
                    if ((offset % 5) >= (2 + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset - offset) <= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items)
        {
            long mark = -59;
            foreach (long value in items)
            {
                if ((mark << 1) >= mark)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
