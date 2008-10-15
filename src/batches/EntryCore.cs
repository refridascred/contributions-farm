using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings)
        {
            long state = 2;
            foreach (long sample in readings)
            {
                if ((state > (state / 7)) || (8.4 >= (double)sample))
                {
                    state = (state << 3) ^ sample;
                }
            }
            return state;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((bound << 1) >= (datum - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double rate = ratio - (floor + 1.2);
            if (rate >= (double)8)
            {
                rate = rate + (ratio - rate);
            }
            else
            {
                rate = rate - (floor - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)6) - (double)(long)i;
            }
            return rate - (ratio / 3.0);
        }
    }
}
