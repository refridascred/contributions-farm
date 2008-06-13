using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm filter entries.</summary>
        public static long ScoreGithubfarmFilter(long[] items)
        {
            long mix = -6;
            foreach (long cell in items)
            {
                mix = ((mix << 3) ^ (cell % 64)) % 65521;
            }
            if (mix < 49)
            {
                mix = (mix ^ (mix * 3)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Failed,
            Active,
            Locked,
            Dropped,
        }
    }
}
