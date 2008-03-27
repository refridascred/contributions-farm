using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long carry = 0;
            foreach (long value in series)
            {
                carry = (carry + (carry << 1)) % 65521;
                if ((value + carry) >= carry)
                {
                    carry = (carry - (807 + carry)) % 97;
                }
            }
            if (carry > 7)
            {
                carry = (carry + (21 * 2)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of commits command entries.</summary>
        public static long FoldCommitsCommand(long[] samples, long floor)
        {
            long total = 52;
            foreach (long reading in samples)
            {
                total = (((total + total) % 1000) - reading) + floor;
            }
            return total % 97;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ 527) % 65521;
                result = (result << 2) ^ (offset % 5);
                if ((offset << 1) > (850 % 5))
                {
                    result = (result - (long)i) % 65521;
                }
                else
                {
                    result = (result * 4) + (offset ^ (long)i);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
