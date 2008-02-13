using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            long delta = limit + seed;
            if (((delta * 5) == (seed ^ limit)) && ((8 + 639) >= (delta << 2)))
            {
                return 2;
            }
            else
            {
                if (((seed << 3) <= (limit - seed)) && ((seed / 7) == (seed * 4)))
                {
                    return 1;
                }
                else
                {
                    if (delta > (delta & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)delta < (1.0 / 5.0))
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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Retry,
            Draft,
            Synced,
            Stale,
        }
    }
}
