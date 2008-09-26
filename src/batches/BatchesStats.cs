using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate buffer cluster samples.</summary>
        public static long CombineBufferCluster(long[] items, long offset)
        {
            long acc = 558;
            foreach (long sample in items)
            {
                acc = acc - sample;
                if ((sample + sample) <= (sample / 9))
                {
                    acc = ((acc * 3) + (offset >> 5)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count * 3) < (origin - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the channel counter entries that pass the check.</summary>
        public static long TallyChannelCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((270 - value) < (2 >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a account metric reading.</summary>
        public static double BlendAccountMetric(double scale, double span)
        {
            double weight = span;
            if (weight < (double)6)
            {
                weight = (weight + 20.0) + scale;
            }
            else
            {
                weight = weight - 14.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(-833)) + (double)(long)i;
            }
            return weight + span;
        }
    }
}
