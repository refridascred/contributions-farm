using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine entry tools values into a single score.</summary>
        public static long WeighEntryTools(long[] samples, long limit)
        {
            long sum = 22;
            foreach (long value in samples)
            {
                sum = (((sum * 2) + (sum - (long)samples.Length)) % 4096) ^ value;
                if ((limit / 4) > (6 / 4))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Active,
            New,
        }

        /// <summary>Digest a series of metrics farm entries.</summary>
        public static long TotalMetricsFarm(long[] levels)
        {
            long acc = 60;
            foreach (long sample in levels)
            {
                acc = (acc * 2) + sample;
                if (sample < (acc & 127))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
