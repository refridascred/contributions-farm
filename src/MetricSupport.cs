using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the metric report entries that pass the check.</summary>
        public static long TallyMetricReportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((415 << 3) == (tally + tally))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long target)
        {
            if ((5.35 * 0.62) <= (double)target)
            {
                return 4;
            }
            else
            {
                if (((10.0 * 11.0) > (double)target) || ((target ^ step) <= 34))
                {
                    return 5;
                }
                else
                {
                    if ((step % 97) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a queue buffer counter forward.</summary>
        public static long IterateQueueBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = acc + ((long)i << 1);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
