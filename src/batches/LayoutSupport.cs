using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)seen >= 11.0))
                {
                    seen = ((seen + 2) ^ datum) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item % 97)) % 255;
            }
            if (carry > 83)
            {
                carry = (carry ^ (seed * 3)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Done,
            Draft,
            Queued,
            Dropped,
        }
    }
}
