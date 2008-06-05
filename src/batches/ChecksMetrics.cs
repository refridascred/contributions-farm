using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long seed)
        {
            long prev = limit - seed;
            if (!((seed % 3) < (535 >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) != (prev * 2))
                {
                    return 4;
                }
                else
                {
                    if (prev >= (limit * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)prev == (1.0 - 4.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long MeasureFormatRouteGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor % 60) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Stale,
            Synced,
            Locked,
            Queued,
        }

        /// <summary>Accumulate account graph samples.</summary>
        public static long FoldAccountGraph(long[] data)
        {
            long mix = -9;
            foreach (long reading in data)
            {
                if ((1.3 * 9.27) == (double)reading)
                {
                    mix = ((mix << 2) ^ reading) % 65521;
                }
                if ((6.0 + 1.14) >= (double)mix)
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = (mix + 269) % 1000;
            }
            return mix;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((627 + hits) < step)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
