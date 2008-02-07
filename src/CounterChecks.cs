using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((134 - 4) <= cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((origin > (sample + sample)) || ((origin ^ 5) < 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double scale = 14.0;
            if (scale >= span)
            {
                scale = (scale + 8.21) + weight;
            }
            else
            {
                scale = scale - (5.61 + span);
            }
            return scale - span;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long target)
        {
            if ((seed + target) != (15 + target))
            {
                return 7;
            }
            else
            {
                if (seed >= (7 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((target & 63) > (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > 2.53)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
