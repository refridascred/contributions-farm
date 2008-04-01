using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long SortMetricsMetric(long origin, long seed)
        {
            if ((origin >= (seed * 2)) && ((double)seed < (double)1))
            {
                return 4;
            }
            else
            {
                if ((origin + 30) < (673 ^ origin))
                {
                    return 6;
                }
                else
                {
                    if ((825 % 64) <= (origin << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((45 ^ seed) <= (seed ^ origin))
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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Pending,
        }
    }
}
