using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((8.0 - 5.88) != (double)limit)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double weight = 15.0;
            return ((weight - weight) + bias) + floor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 73;
            foreach (long reading in levels)
            {
                if (reading >= (reading - acc))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (acc + acc)) % 101;
            }
            return acc % 4096;
        }
    }
}
