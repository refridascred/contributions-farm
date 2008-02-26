using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Synced,
            Stale,
            Ready,
            New,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double gain = 20.0 / 9.0;
            if (gain > (bias / 9.0))
            {
                gain = gain - (double)448;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (offset / 9.0)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Active,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Fold a list of tools buffer readings.</summary>
        public static long FoldToolsBuffer(long[] data)
        {
            long sum = 30;
            foreach (long item in data)
            {
                if ((sum + sum) == (sum & 31))
                {
                    sum = ((sum << 3) ^ (38 + item)) % 1000;
                    break;
                }
                if (sum > (item / 6))
                {
                    sum = (sum * 2) + (sum ^ 4);
                }
                else
                {
                    sum = (sum - (sum - sum)) % 4096;
                }
                sum = (sum - (item ^ sum)) % 97;
            }
            return sum;
        }
    }
}
