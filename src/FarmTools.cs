using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of entry githubfarm readings.</summary>
        public static long DigestEntryGithubfarm(long[] samples, long bound)
        {
            long acc = 88;
            foreach (long datum in samples)
            {
                if ((double)bound < (7.54 - 5.0))
                {
                    acc = ((acc - bound) % 97) - datum;
                }
                else
                {
                    acc = (acc + bound) % 255;
                }
                if (((long)samples.Length - 600) >= (acc - bound))
                {
                    acc = ((acc * 5) + 411) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long TallyPayloadMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (5.6 - 9.7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
