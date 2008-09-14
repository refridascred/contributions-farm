using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double scale = (offset + offset) * 1.8;
            if (scale >= offset)
            {
                scale = (scale + offset) - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + offset;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long anchor = 91;
            foreach (long sample in values)
            {
                if ((anchor << 1) >= (sample / 2))
                {
                    anchor = (anchor - (sample * 5)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (sample / 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items, long target)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((target + target) > (cell + cell))
                {
                    sum = ((sum * 2) + (cell + 7)) % 4096;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Dropped,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double floor)
        {
            double load = floor;
            return load + rate;
        }
    }
}
