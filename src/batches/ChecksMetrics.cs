using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen << 1) <= (4 + seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((limit - 3) == (tally / 2)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples)
        {
            long anchor = 451;
            foreach (long entry in samples)
            {
                if (((double)entry < (9.4 - 9.9)) || ((entry * 4) < entry))
                {
                    anchor = (anchor ^ ((-6) - entry)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((337 + seen) > seen)
                {
                    seen = ((seen + 1) + item) + seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long floor)
        {
            long span = bound - floor;
            if (((span << 3) >= floor) && ((bound ^ 2) < (span << 2)))
            {
                return 1;
            }
            else
            {
                if (57 >= (bound - floor))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 5) < bound)
                    {
                        return 3;
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
