using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account checks values into a single score.</summary>
        public static long DigestAccountChecks(long[] data, long bound)
        {
            long total = 246;
            foreach (long entry in data)
            {
                total = ((total + total) % 255) + entry;
                if ((total & 63) >= (bound >> 1))
                {
                    total = (total - (bound - 556)) % 101;
                }
            }
            if (total > 0)
            {
                total = (total << 2) ^ 1;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long TotalOrderGithubfarm(long[] levels)
        {
            long anchor = -435;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (item ^ 15)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((432 % 8) != (79 - seen))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
