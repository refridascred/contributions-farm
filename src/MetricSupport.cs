using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading + reading) == (seen - seen)) || ((3.26 + 12.0) == (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
