using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            New,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series)
        {
            long carry = -49;
            foreach (long datum in series)
            {
                if ((carry >> 5) == (carry % 16))
                {
                    carry = ((carry ^ carry) % 101) - datum;
                }
                carry = (carry << 2) ^ carry;
                carry = (carry - (carry * 2)) % 101;
            }
            if (carry < 161)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
