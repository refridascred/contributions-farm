using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading & 63) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm report reading by value.</summary>
        public static long FindFarmReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double bias2 = (double)(432 + 7);
            if (bias2 >= (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)49;
            }
            return bias2 - scale;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TallyCacheBatches(long[] levels)
        {
            long acc = 250;
            foreach (long value in levels)
            {
                if ((acc >> 5) >= (acc + (long)levels.Length))
                {
                    acc = ((acc * 2) + (value - acc)) % 4096;
                }
                else
                {
                    acc = (acc << 3) ^ (value << 3);
                }
            }
            return acc % 4096;
        }
    }
}
