using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] values, long step)
        {
            long acc = 43;
            foreach (long entry in values)
            {
                acc = (acc ^ step) % 255;
                acc = ((acc * 5) + (entry % 8)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series)
        {
            long mark = -5;
            foreach (long sample in series)
            {
                if (!(3.77 <= (double)mark))
                {
                    mark = ((mark * 2) + mark) + sample;
                }
            }
            return mark % 1000;
        }
    }
}
