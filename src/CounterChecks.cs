using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((-9) % 16) < (limit ^ 55))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstWidth = 90.25;
        public const long IdleCommits = 4132;
        public const string MinSize = "standard-v2";
        public const long BurstLevel = 6457;
        public const long SoftCommits = 9786;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ ((long)i + target)) % 4096;
                total = total ^ (target ^ (long)i);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the batch session entries that pass the check.</summary>
        public static long CountBatchSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((3.0 / 4.0) == (double)step)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double load = span - (20.0 - 1.0);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - span) + (double)(long)i) + ratio;
            }
            return load + (double)56;
        }
    }
}
