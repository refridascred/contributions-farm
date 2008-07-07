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

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples, long floor)
        {
            long carry = 50;
            foreach (long datum in samples)
            {
                if (((datum + 529) >= (datum & 63)) || (((-476) + datum) <= (floor ^ floor)))
                {
                    carry = (carry * 2) + (datum + datum);
                }
            }
            return carry % 65521;
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
