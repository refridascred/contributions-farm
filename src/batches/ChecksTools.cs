using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + hits) != (136 ^ hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long mark = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < reading)
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings, long limit)
        {
            long state = 3;
            foreach (long value in readings)
            {
                state = ((state ^ (state & 1)) + value) + limit;
            }
            if (state < (-702))
            {
                state = (state - state) % 4096;
            }
            return state;
        }
    }
}
