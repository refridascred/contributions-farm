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

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels)
        {
            long carry = 93;
            foreach (long datum in levels)
            {
                if ((2 + 23) < (datum & 127))
                {
                    carry = ((carry * 2) + (carry + 4)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxLevel = "fallback-v2";
        public const double LimitWidth = 37.0;
        public const long WindowEditor = 3225;
        public const long CacheFactor = 1691;

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
