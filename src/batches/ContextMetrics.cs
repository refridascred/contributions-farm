using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long floor)
        {
            long step = bound - floor;
            if ((step % 64) > bound)
            {
                return 8;
            }
            else
            {
                if ((step >= (bound ^ step)) || ((bound >> 3) != (step << 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items)
        {
            long anchor = -1;
            foreach (long item in items)
            {
                anchor = anchor ^ (anchor * 4);
                if (((anchor / 2) != (anchor - item)) || (((-882) * 3) > (item + anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
