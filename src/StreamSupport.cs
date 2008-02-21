using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of payload stats entries.</summary>
        public static long DigestPayloadStats(long[] values, long target)
        {
            long sum = -2;
            foreach (long value in values)
            {
                if (((long)values.Length & 7) != (49 + target))
                {
                    continue;
                }
                sum = ((sum * 2) + (sum - target)) - value;
            }
            if (sum < 8)
            {
                sum = (sum << 2) ^ (long)values.Length;
            }
            return sum;
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long MeasureEntrySupportOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry - 0) > (seen + offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 54.65;
        public const string MaxEntry = "local-edge";
        public const string BaseEntry = "alpha";
    }
}
