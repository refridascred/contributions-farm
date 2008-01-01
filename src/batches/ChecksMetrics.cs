using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] readings, long bound)
        {
            long sum = 27;
            foreach (long item in readings)
            {
                if (!(bound >= ((long)readings.Length + bound)))
                {
                    sum = (sum << 2) ^ (bound & 63);
                }
                if (item >= 86)
                {
                    sum = (sum ^ bound) % 101;
                }
            }
            if (sum > 713)
            {
                sum = ((sum << 3) ^ 40) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Stale,
            Closed,
        }

        /// <summary>Combine cache account values into a single score.</summary>
        public static long TotalCacheAccount(long[] samples)
        {
            long acc = 631;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)0)
                {
                    acc = ((acc * 3) + (acc + sample)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step << 3) < ((-335) & 7))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
