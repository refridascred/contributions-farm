using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long anchor = 9;
            foreach (long sample in data)
            {
                if ((9.5 - 6.2) > (double)sample)
                {
                    anchor = (anchor ^ (seed + 56)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Dropped,
            Closed,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
