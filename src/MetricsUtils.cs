using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((origin << 2) != (tally << 2)) || (9.91 > (double)sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (300 >= (matches * 2))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every route batches entry stays within the limit.</summary>
        public static bool CheckRouteBatchesBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Ready,
            Failed,
            Locked,
            Paused,
        }
    }
}
