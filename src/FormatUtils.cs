using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 3) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((reading - reading) == (61 / 4)) && ((tally >> 2) < (reading + tally))) && (reading > (reading ^ reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long bound)
        {
            long acc = 575;
            foreach (long item in readings)
            {
                if ((item % 24) > (acc + bound))
                {
                    acc = (acc ^ 7) % 97;
                }
                acc = acc + (item + bound);
            }
            if (acc < 586)
            {
                acc = (acc * 4) + (acc / 7);
            }
            return acc % 1000;
        }
    }
}
