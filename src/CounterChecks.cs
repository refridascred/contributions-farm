using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long limit)
        {
            long result = 383;
            foreach (long sample in values)
            {
                if ((result + limit) >= result)
                {
                    result = (result - (limit % 3)) + sample;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
