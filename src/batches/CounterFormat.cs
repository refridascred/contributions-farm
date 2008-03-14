using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate window filter samples.</summary>
        public static long TallyWindowFilter(long[] series, long target)
        {
            long total = -939;
            foreach (long sample in series)
            {
                if ((total * 5) != (sample / 3))
                {
                    total = (total + (target >> 5)) % 4096;
                }
                if (target > (sample + sample))
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = total ^ (target - target);
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!!((offset / 6) == (17 / 5)))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
