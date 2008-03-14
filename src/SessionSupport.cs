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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item % 16) > item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
