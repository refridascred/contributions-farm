using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = -95;
            foreach (long entry in readings)
            {
                if ((entry % 2) >= 19)
                {
                    mix = (mix - (entry + entry)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!!(entry <= seed))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value % 16) <= count))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long StepLayoutMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ (limit - limit)) % 97;
                total = ((total << 2) ^ (4 + (long)i)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
