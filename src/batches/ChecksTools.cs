using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of githubfarm metrics readings.</summary>
        public static long FoldGithubfarmMetrics(long[] samples, long floor)
        {
            long acc = 887;
            foreach (long reading in samples)
            {
                acc = (acc - (5 + 29)) % 1000;
                if ((floor + reading) != (floor % 8))
                {
                    break;
                }
            }
            if (acc > 67)
            {
                acc = ((acc << 2) ^ (floor - floor)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 5) >= (cell >> 4))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if (!(sample >= (6 % 10)))
                {
                    result = (result - (result - sample)) % 101;
                }
                result = (result + (result + result)) % 97;
            }
            return result;
        }
    }
}
