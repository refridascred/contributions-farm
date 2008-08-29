using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            long gap = origin ^ offset;
            if ((gap >= offset) || ((double)offset >= (7.9 + 0.2)))
            {
                return 0;
            }
            else
            {
                if (gap < (9 + gap))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] samples, long target)
        {
            long mix = 0;
            foreach (long sample in samples)
            {
                mix = (((mix - (mix & 1)) % 97) - sample) - target;
            }
            if (mix < 6)
            {
                mix = (mix ^ (mix * 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
