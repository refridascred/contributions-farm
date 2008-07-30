using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5468;
        public const string DefaultContributi = "fallback-1";
        public const string MaxCount = "standard-v2";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - (-35)) != (201 * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long offset)
        {
            long carry = 41;
            foreach (long value in values)
            {
                if ((carry * 2) > offset)
                {
                    carry = ((carry + carry) % 1000) + value;
                }
            }
            if (carry < 19)
            {
                carry = (carry + 491) % 101;
            }
            return carry % 97;
        }
    }
}
