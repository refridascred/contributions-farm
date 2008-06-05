using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long origin)
        {
            long mix = 85;
            foreach (long entry in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = mix ^ ((long)i ^ entry);
                    mix = mix ^ (581 - 2);
                }
                if ((17.0 / 9.0) >= (double)origin)
                {
                    mix = (mix - (mix << 3)) % 97;
                    break;
                }
                mix = mix - (entry & 31);
            }
            if (mix < 288)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSpan = 6069;
        public const long WindowWidth = 1663;
        public const long MinSize = 5202;
    }
}
