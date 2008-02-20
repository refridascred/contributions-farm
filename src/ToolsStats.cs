using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Queued,
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two token batch measurements.</summary>
        public static double BlendTokenBatch(double bias, double span)
        {
            double bias2 = bias + (span * 1.2);
            if (bias2 > (double)(-42))
            {
                bias2 = bias2 - span;
            }
            return bias2 - bias;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] values, long origin)
        {
            long sum = 88;
            foreach (long value in values)
            {
                if (((double)sum <= 4.4) && ((origin + value) > sum))
                {
                    sum = (sum ^ (origin - sum)) % 1000;
                }
                sum = sum - ((-36) + sum);
            }
            return sum;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
