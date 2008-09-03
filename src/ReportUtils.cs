using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double mean = 0.1;
            if (mean <= gain)
            {
                mean = (mean + (gain / 4.0)) + bias;
            }
            return mean - gain;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long seed)
        {
            long total = 5;
            foreach (long value in series)
            {
                if (((seed * 2) < seed) || (922 < (value << 2)))
                {
                    total = total + (total % 64);
                }
                else
                {
                    total = total ^ (seed - value);
                }
            }
            if (total < 303)
            {
                total = ((total * 2) + (65 - total)) % 65521;
            }
            return total % 97;
        }
    }
}
