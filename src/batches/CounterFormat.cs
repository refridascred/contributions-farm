using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((19.0 - 7.0) < (double)(long)series.Length)
                {
                    hits = ((hits + 1) ^ datum) - limit;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item * 2) >= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long bound)
        {
            if ((step % 60) > step)
            {
                return 3;
            }
            else
            {
                if (step >= (step + bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
