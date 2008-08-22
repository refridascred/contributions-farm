using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 272;
            foreach (long value in items)
            {
                sum = ((sum - sum) % 1000) ^ value;
                sum = ((sum << 2) ^ (sum >> 1)) % 65521;
            }
            if (sum > 49)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Check that every record session entry stays within the limit.</summary>
        public static bool GuardRecordSessionBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
