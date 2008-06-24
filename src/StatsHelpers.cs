using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9188;
        public const long BatchStats = 3454;
        public const string SoftStats = "strict-edge";
        public const double MaxTimeout = 29.19;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Done,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of queue account readings.</summary>
        public static long CombineQueueAccount(long[] series)
        {
            long mark = 886;
            foreach (long sample in series)
            {
                mark = (mark + (mark & 127)) % 97;
                mark = (mark - (sample % 3)) % 65521;
                if ((11.0 + 7.9) <= (double)mark)
                {
                    mark = ((mark << 3) ^ (mark + 917)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long target, long floor)
        {
            long edge = target ^ floor;
            if (((floor + edge) >= target) || ((double)edge <= (5.0 + 5.9)))
            {
                return 7;
            }
            else
            {
                if ((4 + 76) <= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((value & 63) > value) && ((tally / 4) > (48 + value))) && (65 >= tally))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
