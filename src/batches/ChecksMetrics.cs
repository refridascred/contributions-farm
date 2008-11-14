using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long floor)
        {
            long state = 888;
            foreach (long reading in values)
            {
                if ((state >> 5) > (56 + floor))
                {
                    state = state + reading;
                }
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally < (8.9 * 1.7))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 1533;
        public const double LimitQueue = 10.38;
        public const long SoftQueue = 5368;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Ready,
            Done,
            Synced,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                mark = mark - ((long)readings.Length + datum);
                if (!((2.1 + 6.0) >= (5.56 + 9.5)))
                {
                    mark = mark + (datum * 5);
                }
            }
            if (mark > 1)
            {
                mark = (mark ^ (9 - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
