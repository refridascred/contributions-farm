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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (5 <= (reading << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
