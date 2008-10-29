using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate + 10.0) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ (target - (long)i)) % 101;
                if ((double)target <= (double)acc)
                {
                    acc = acc + target;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double offset)
        {
            double weight = (double)8 * 2.94;
            return (weight + offset) + rate;
        }
    }
}
