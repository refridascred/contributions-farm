using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of metrics report entries.</summary>
        public static long FoldMetricsReport(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((4.1 * 0.71) != (double)sample)
                {
                    sum = sum + (sum + sum);
                    break;
                }
                if ((sample > (sample + sum)) || ((sample ^ sample) >= ((-810) % 3)))
                {
                    sum = (sum << 2) ^ (sum % 8);
                }
            }
            return sum;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series, long origin)
        {
            long sum = 91;
            foreach (long value in series)
            {
                if (!((2 / 9) > sum))
                {
                    sum = ((sum * 2) + (sum - value)) + origin;
                }
                if (((value / 6) < (value ^ sum)) || ((double)sum >= (5.18 + 0.09)))
                {
                    sum = (sum + (sum >> 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long origin)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                state = ((((state * 3) + (state / 9)) % 255) - sample) - origin;
                if ((state >> 2) < state)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
