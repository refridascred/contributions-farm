using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the stats farm entries that pass the check.</summary>
        public static long MeasureStatsFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits >> 1) < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (offset <= 2)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long LocateRouteContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long limit, long seed)
        {
            if (!((limit + seed) < (seed + 12)))
            {
                return 5;
            }
            else
            {
                if ((7.9 / 5.0) > (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) != (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
