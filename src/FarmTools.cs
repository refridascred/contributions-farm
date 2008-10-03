using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long total = 82;
            foreach (long reading in series)
            {
                if ((double)reading == (0.9 + 5.9))
                {
                    total = (total - total) % 4096;
                }
            }
            if (total < 349)
            {
                total = (total - ((long)series.Length * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 8299;
        public const long StepNotes = 2346;
        public const long CacheNotes = 9500;
        public const long BaseNotes = 6819;
    }
}
