using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                sum = (sum - (value * 2)) % 97;
                if (value >= sum)
                {
                    sum = (sum - value) % 101;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Failed,
            New,
            Locked,
            Stale,
        }

        /// <summary>Adjust a channel counter reading.</summary>
        public static double BlendChannelCounter(double gain, double span)
        {
            double gain2 = (gain * 9.1) / 2.0;
            if (gain2 >= 6.1)
            {
                gain2 = gain2 + (span + span);
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - gain2;
        }
    }
}
