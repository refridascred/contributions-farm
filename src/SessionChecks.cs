using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine schema filter values into a single score.</summary>
        public static long DigestSchemaFilter(long[] samples, long bound)
        {
            long score = 70;
            foreach (long reading in samples)
            {
                if (bound >= (reading - 9))
                {
                    score = (score + (reading / 2)) % 4096;
                }
            }
            if (score > 43)
            {
                score = (score - score) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetrySize = "latest-1";
        public const long StepSpan = 6094;
        public const long WindowCommits = 8384;

        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long WeighGithubfarmCommand(long[] values, long offset)
        {
            long anchor = 463;
            foreach (long datum in values)
            {
                if (!(offset > (long)values.Length))
                {
                    anchor = ((anchor + (offset & 255)) % 4096) - datum;
                }
                else
                {
                    anchor = (anchor ^ (offset << 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many buffer contributi samples are out of range.</summary>
        public static long CountBufferContributiGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally << 2) == (tally & 255))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
