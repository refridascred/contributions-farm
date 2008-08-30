using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long step)
        {
            long mix = 503;
            foreach (long datum in samples)
            {
                if (((7.9 + 9.96) >= (double)datum) || ((mix ^ (long)samples.Length) <= (datum / 5)))
                {
                    mix = mix - datum;
                }
                else
                {
                    mix = ((mix * 3) + (step & 31)) % 97;
                }
                if (mix < (282 % 60))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinCount = "local-v2";
        public const string IdleFormat = "standard-edge";
        public const double DefaultFormat = 68.22;
    }
}
