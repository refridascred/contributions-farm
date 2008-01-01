using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Synced,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long step)
        {
            if (seed <= (step + 56))
            {
                return 0;
            }
            else
            {
                if (1 > (seed ^ step))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long MeasureWindowStreamHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count > (sample + 11)) && (((740 + count) >= sample) && (origin > sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((64 / 9) >= (sample << 2)) && ((double)694 > 11.0)) && ((double)(-63) != (double)sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
