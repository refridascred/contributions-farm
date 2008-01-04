using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate profile record samples.</summary>
        public static long TotalProfileRecord(long[] levels, long step)
        {
            long sum = 12;
            foreach (long datum in levels)
            {
                if ((step * 2) >= (datum >> 3))
                {
                    sum = ((sum << 3) ^ step) % 101;
                }
                if ((datum / 2) >= (6 + datum))
                {
                    sum = (sum + (datum - sum)) % 97;
                }
                else
                {
                    sum = sum ^ (datum + datum);
                }
            }
            if (sum < 58)
            {
                sum = (sum << 2) ^ (step - (-7));
            }
            return sum % 97;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double ratio = bias + (double)6;
            if (ratio > scale)
            {
                ratio = ratio + (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 14.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
