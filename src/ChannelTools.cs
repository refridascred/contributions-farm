using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values)
        {
            long acc = 5;
            foreach (long sample in values)
            {
                acc = ((acc * 4) + (sample + sample)) % 4096;
                if ((double)(-61) == (double)acc)
                {
                    acc = (acc * 2) + (sample / 2);
                }
            }
            if (acc < 102)
            {
                acc = ((acc * 2) + (9 - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length == (5 + step))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long floor)
        {
            if ((3.8 + 5.6) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((39 - floor) >= (floor + bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
