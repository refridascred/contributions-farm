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

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long floor)
        {
            long anchor = 995;
            foreach (long reading in data)
            {
                anchor = (((anchor ^ (189 - 32)) % 97) + reading) + floor;
            }
            return anchor % 4096;
        }
    }
}
