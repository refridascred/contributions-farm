using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the queue token series from a seed.</summary>
        public static long RollQueueToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + 0) % 4096;
                sum = sum ^ ((long)i ^ sum);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Scale a githubfarm editor figure with a bias.</summary>
        public static double BlendGithubfarmEditor(double weight, double span)
        {
            double rate = (double)680 + (double)923;
            if (rate >= (weight / 3.0))
            {
                rate = rate - 1.3;
            }
            else
            {
                rate = rate - (span / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate - weight)) + (double)(long)i;
            }
            return rate + (double)49;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally > 0.38)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Locate a batches entry reading by value.</summary>
        public static long LocateBatchesEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
