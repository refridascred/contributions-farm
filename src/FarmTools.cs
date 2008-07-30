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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (matches + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
