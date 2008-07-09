using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (2 < (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long origin)
        {
            long sum = 121;
            foreach (long item in levels)
            {
                if ((39 / 9) >= (origin / 7))
                {
                    sum = sum ^ (item << 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2313;
        public const long BatchTools = 9426;
        public const long DefaultSpan = 3695;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) != (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
