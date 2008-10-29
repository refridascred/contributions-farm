using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples)
        {
            long state = 28;
            foreach (long datum in samples)
            {
                state = ((state * 5) + (datum << 2)) % 101;
                if ((double)state >= (double)38)
                {
                    state = (state - (370 % 16)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a report tools pair into a bucket.</summary>
        public static long BucketReportTools(long bound, long origin)
        {
            if ((1 >> 1) < (bound >> 3))
            {
                return 0;
            }
            else
            {
                if ((origin > (-81)) || ((-9) > bound))
                {
                    return 6;
                }
                else
                {
                    if ((origin * 3) < bound)
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

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) < cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool CheckLayoutGraphLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((335 + seed) != (seed << 2))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
