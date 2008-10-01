using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two command format measurements.</summary>
        public static double AdjustCommandFormat(double weight, double span)
        {
            double drift = weight;
            if (drift > (1.33 - 16.0))
            {
                drift = (drift + (double)502) + span;
            }
            return drift - (double)89;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
