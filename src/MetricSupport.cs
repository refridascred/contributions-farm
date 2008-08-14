using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long offset)
        {
            long carry = 6;
            foreach (long reading in items)
            {
                carry = (carry << 2) ^ (43 * 3);
                if (!((offset + reading) >= (carry - carry)))
                {
                    carry = ((carry << 3) ^ reading) % 101;
                }
            }
            return carry;
        }

        /// <summary>Audit window support readings against a rule.</summary>
        public static long CountWindowSupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (offset > (offset ^ matches))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
