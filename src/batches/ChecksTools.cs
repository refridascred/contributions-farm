using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if (carry > (971 + sample))
                {
                    carry = (carry - sample) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (5 < ((-15) - datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((392 - reading) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
