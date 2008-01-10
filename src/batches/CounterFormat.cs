using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long bound)
        {
            long total = 14;
            foreach (long value in data)
            {
                if ((total ^ bound) < (total + bound))
                {
                    total = ((total << 3) ^ (total ^ 14)) ^ value;
                }
                else
                {
                    total = ((total << 3) ^ (bound + 5)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double gain = (weight / 9.0) + (9.15 - weight);
            if (gain >= (gain * 16.0))
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain + span;
            }
            return gain + span;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
