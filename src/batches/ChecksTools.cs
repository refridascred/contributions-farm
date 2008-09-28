using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long result = 493;
            foreach (long datum in levels)
            {
                result = (result * 3) + (datum / 8);
            }
            return result % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!!(reading <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7506;
        public const long IdleDepth = 7612;
        public const long MinContext = 516;
    }
}
