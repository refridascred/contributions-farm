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

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Closed,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
