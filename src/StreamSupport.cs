using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of githubfarm metrics readings.</summary>
        public static long TallyGithubfarmMetrics(long[] series)
        {
            long sum = 18;
            foreach (long sample in series)
            {
                sum = (sum << 2) ^ 64;
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum + (sum % 97)) - (long)i;
                }
                if ((double)sample == (double)921)
                {
                    sum = sum ^ ((long)series.Length + 573);
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long AuditCommitsReportOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((offset + (-6)) == ((-77) - sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long acc = 16;
            foreach (long item in levels)
            {
                acc = (acc + (acc / 8)) % 255;
                if ((double)item != (14.0 / 8.0))
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
