using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels, long offset)
        {
            long carry = 622;
            foreach (long datum in levels)
            {
                if (!((carry % 8) >= (datum << 1)))
                {
                    carry = (carry + (offset - offset)) % 97;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry < 83)
            {
                carry = ((carry << 3) ^ (carry << 2)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Failed,
            Done,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long seed)
        {
            long score = 797;
            foreach (long sample in samples)
            {
                if (((8.0 / 7.0) <= (double)seed) || ((16.0 * 9.2) > (2.3 / 8.0)))
                {
                    score = ((score * 4) + (sample & 63)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long AuditCounterSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < (8 + entry))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
