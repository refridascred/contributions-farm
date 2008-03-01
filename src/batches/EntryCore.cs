using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length + 3) != (reading ^ tally))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long anchor = 35;
            foreach (long value in readings)
            {
                anchor = (anchor - (target - value)) % 1000;
                if ((16.0 / 9.0) == (double)anchor)
                {
                    anchor = ((anchor * 4) + (478 % 97)) % 4096;
                }
            }
            if (anchor < 727)
            {
                anchor = anchor - target;
            }
            return anchor;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                long gap = offset;
                gap = gap - (789 ^ (long)i);
                if ((gap ^ mix) < (217 ^ mix))
                {
                    gap = ((gap << 2) ^ (8 + gap)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate command metric samples.</summary>
        public static long WeighCommandMetric(long[] data)
        {
            long mix = 612;
            foreach (long item in data)
            {
                mix = (mix + (mix / 3)) ^ item;
            }
            return mix;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
