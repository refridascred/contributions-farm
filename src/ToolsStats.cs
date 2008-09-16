using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum - seen) > (datum + seed)) || ((seen - seen) > (datum + 791)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data)
        {
            long total = 617;
            foreach (long sample in data)
            {
                if (sample > (total - 81))
                {
                    total = (total - (sample * 5)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long floor, long seed)
        {
            long diff = floor + seed;
            if ((diff + diff) >= (seed + diff))
            {
                return 8;
            }
            else
            {
                if ((51 & 127) <= (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if ((diff % 97) <= (seed - diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 1) > (seed + seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
