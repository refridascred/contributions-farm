using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long AuditWindowStreamHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (bound - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long DigestCounterAlready(long[] items, long origin)
        {
            long anchor = 790;
            foreach (long item in items)
            {
                if (10.0 <= (double)item)
                {
                    anchor = (anchor - (origin ^ item)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((item + 72) <= (step * 3)) || ((double)item < (8.5 / 5.0))) || (item > step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryDepth = "local";
        public const long BatchInterval = 1772;
        public const long SoftTimeout = 5018;
        public const long StepWindow = 1929;
        public const long WindowDepth = 1682;
    }
}
