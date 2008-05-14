using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine token record values into a single score.</summary>
        public static long DigestTokenRecord(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                mix = mix ^ (item << 2);
                if (((mix & 63) >= (item * 2)) || ((6.73 / 3.0) <= (double)mix))
                {
                    mix = mix ^ ((-2) + mix);
                }
            }
            return mix;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            long lane = floor - offset;
            if ((13.0 + 6.61) < (double)lane)
            {
                return 5;
            }
            else
            {
                if (!((double)floor >= (8.79 + 6.49)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Paused,
            Retry,
        }
    }
}
