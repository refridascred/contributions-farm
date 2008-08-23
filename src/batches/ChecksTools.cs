using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound / 2) <= (tally % 10))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings)
        {
            long carry = 7;
            foreach (long entry in readings)
            {
                if (!((double)entry < 4.4))
                {
                    carry = (carry + (entry << 3)) % 65521;
                }
                carry = (carry - entry) % 255;
            }
            if (carry > 9)
            {
                carry = carry ^ 9;
            }
            return carry % 4096;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
