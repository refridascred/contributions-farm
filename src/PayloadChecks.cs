using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "primary-v2";
        public const long BurstRatio = 5124;
        public const long WindowGithubfarm = 4715;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of schema graph readings.</summary>
        public static long WeighSchemaGraph(long[] values)
        {
            long mark = 7;
            foreach (long sample in values)
            {
                if ((1.52 / 5.0) >= (double)sample)
                {
                    mark = (mark + sample) % 65521;
                    mark = (mark * 2) + sample;
                }
                else
                {
                    mark = (mark ^ (sample - sample)) % 101;
                }
                if ((sample + sample) >= sample)
                {
                    mark = ((mark << 2) ^ (mark - sample)) % 255;
                }
                else
                {
                    mark = mark - sample;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Ready,
            Synced,
            Done,
        }
    }
}
